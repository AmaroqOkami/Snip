﻿#region File Information
/*
 * Copyright (C) 2012-2017 David Rudie
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02111, USA.
 */
#endregion

namespace Winter
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using Microsoft.Win32;
    using IWshRuntimeLibrary;

    public static class Settings
    {
        public static void CreateStartupShortcut()
        {
            string shortcutLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\SnipBoot.lnk";
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "Boot Snip on windows start";
            shortcut.IconLocation = Environment.CurrentDirectory + "\\Snip.exe";
            shortcut.TargetPath = Environment.CurrentDirectory + "\\Snip.exe";
            shortcut.Save();
        }

        public static void Save()
        {
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(
                string.Format(
                    CultureInfo.InvariantCulture,
                    "SOFTWARE\\{0}\\{1}",
                    AssemblyInformation.AssemblyTitle,
                    Assembly.GetExecutingAssembly().GetName().Version.Major));

            registryKey.SetValue("Player", (int)Globals.PlayerSelection);

            if (Globals.SaveSeparateFiles)
            {
                registryKey.SetValue("Save Separate Files", "true");
            }
            else
            {
                registryKey.SetValue("Save Separate Files", "false");
            }

            if (Globals.SaveAlbumArtwork)
            {
                registryKey.SetValue("Save Album Artwork", "true");
            }
            else
            {
                registryKey.SetValue("Save Album Artwork", "false");
            }

            if (Globals.KeepSpotifyAlbumArtwork)
            {
                registryKey.SetValue("Keep Spotify Album Artwork", "true");
            }
            else
            {
                registryKey.SetValue("Keep Spotify Album Artwork", "false");
            }

            registryKey.SetValue("Album Artwork Resolution", (int)Globals.ArtworkResolution);

            if (Globals.CacheSpotifyMetadata)
            {
                registryKey.SetValue("Cache Spotify Metadata", "true");
            }
            else
            {
                registryKey.SetValue("Cache Spotify Metadata", "false");
            }

            if (Globals.SaveHistory)
            {
                registryKey.SetValue("Save History", "true");
            }
            else
            {
                registryKey.SetValue("Save History", "false");
            }

            if (Globals.DisplayTrackPopup)
            {
                registryKey.SetValue("Display Track Popup", "true");
            }
            else
            {
                registryKey.SetValue("Display Track Popup", "false");
            }

            if (Globals.EmptyFileIfNoTrackPlaying)
            {
                registryKey.SetValue("Empty File If No Track Playing", "true");
            }
            else
            {
                registryKey.SetValue("Empty File If No Track Playing", "false");
            }

            if (Globals.EnableHotkeys)
            {
                registryKey.SetValue("Enable Hotkeys", "true");
            }
            else
            {
                registryKey.SetValue("Enable Hotkeys", "false");
            }

            if (Globals.StartWithWindows)
            {
                registryKey.SetValue("Start with Windows", "true");
            }
            else
            {
                registryKey.SetValue("Start with Windows", "false");
            }

            registryKey.Close();
        }

        public static void Load()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(
                string.Format(
                    CultureInfo.InvariantCulture,
                    "SOFTWARE\\{0}\\{1}",
                    AssemblyInformation.AssemblyTitle,
                    Assembly.GetExecutingAssembly().GetName().Version.Major));

            if (registryKey != null)
            {
                Globals.PlayerSelection = (Globals.MediaPlayerSelection)registryKey.GetValue("Player", Globals.MediaPlayerSelection.Spotify);

                bool saveSeparateFilesChecked = Convert.ToBoolean(registryKey.GetValue("Save Separate Files", false), CultureInfo.InvariantCulture);
                if (saveSeparateFilesChecked)
                {
                    Globals.SaveSeparateFiles = true;
                }
                else
                {
                    Globals.SaveSeparateFiles = false;
                }

                bool saveAlbumArtworkChecked = Convert.ToBoolean(registryKey.GetValue("Save Album Artwork", false), CultureInfo.InvariantCulture);
                if (saveAlbumArtworkChecked)
                {
                    Globals.SaveAlbumArtwork = true;
                }
                else
                {
                    Globals.SaveAlbumArtwork = false;
                }

                bool keepSpotifyAlbumArtwork = Convert.ToBoolean(registryKey.GetValue("Keep Spotify Album Artwork", false), CultureInfo.InvariantCulture);
                if (keepSpotifyAlbumArtwork)
                {
                    Globals.KeepSpotifyAlbumArtwork = true;
                }
                else
                {
                    Globals.KeepSpotifyAlbumArtwork = false;
                }

                Globals.ArtworkResolution = (Globals.AlbumArtworkResolution)registryKey.GetValue("Album Artwork Resolution", Globals.AlbumArtworkResolution.Small);

                bool cacheSpotifyMetadata = Convert.ToBoolean(registryKey.GetValue("Cache Spotify Metadata", true), CultureInfo.InvariantCulture);
                if (cacheSpotifyMetadata)
                {
                    Globals.CacheSpotifyMetadata = true;
                }
                else
                {
                    Globals.CacheSpotifyMetadata = false;
                }

                bool saveHistoryChecked = Convert.ToBoolean(registryKey.GetValue("Save History", false), CultureInfo.InvariantCulture);
                if (saveHistoryChecked)
                {
                    Globals.SaveHistory = true;
                }
                else
                {
                    Globals.SaveHistory = false;
                }

                bool displayTrackPopupChecked = Convert.ToBoolean(registryKey.GetValue("Display Track Popup", true), CultureInfo.InvariantCulture);
                if (displayTrackPopupChecked)
                {
                    Globals.DisplayTrackPopup = true;
                }
                else
                {
                    Globals.DisplayTrackPopup = false;
                }

                bool emptyFileIfNoTrackPlayingChecked = Convert.ToBoolean(registryKey.GetValue("Empty File If No Track Playing", true), CultureInfo.InvariantCulture);
                if (emptyFileIfNoTrackPlayingChecked)
                {
                    Globals.EmptyFileIfNoTrackPlaying = true;
                }
                else
                {
                    Globals.EmptyFileIfNoTrackPlaying = false;
                }

                bool enableHotkeysChecked = Convert.ToBoolean(registryKey.GetValue("Enable Hotkeys", true), CultureInfo.InvariantCulture);
                if (enableHotkeysChecked)
                {
                    Globals.EnableHotkeys = true;
                }
                else
                {
                    Globals.EnableHotkeys = false;
                }

                bool startWithWindowsChecked = Convert.ToBoolean(registryKey.GetValue("Start with Windows", true), CultureInfo.InvariantCulture);
                if (startWithWindowsChecked)
                {
                    Globals.StartWithWindows = true;
                }
                else
                {
                    Globals.StartWithWindows = false;
                }

                Globals.TrackFormat = Convert.ToString(registryKey.GetValue("Track Format", Globals.DefaultTrackFormat), CultureInfo.CurrentCulture);

                Globals.SeparatorFormat = Convert.ToString(registryKey.GetValue("Separator Format", Globals.DefaultSeparatorFormat), CultureInfo.CurrentCulture);

                Globals.ArtistFormat = Convert.ToString(registryKey.GetValue("Artist Format", Globals.DefaultArtistFormat), CultureInfo.CurrentCulture);

                Globals.AlbumFormat = Convert.ToString(registryKey.GetValue("Album Format", Globals.DefaultAlbumFormat), CultureInfo.CurrentCulture);

                registryKey.Close();
            }
            else
            {
                Globals.PlayerSelection = Globals.MediaPlayerSelection.Spotify;
                Globals.SaveSeparateFiles = false;
                Globals.SaveAlbumArtwork = false;
                Globals.KeepSpotifyAlbumArtwork = false;
                Globals.ArtworkResolution = Globals.AlbumArtworkResolution.Small;
                Globals.CacheSpotifyMetadata = true;
                Globals.SaveHistory = false;
                Globals.DisplayTrackPopup = false;
                Globals.EmptyFileIfNoTrackPlaying = true;
                Globals.EnableHotkeys = true;
                Globals.StartWithWindows = false;
                Globals.TrackFormat = Globals.DefaultTrackFormat;
                Globals.SeparatorFormat = Globals.DefaultSeparatorFormat;
                Globals.ArtistFormat = Globals.DefaultArtistFormat;
                Globals.AlbumFormat = Globals.DefaultAlbumFormat;
            }
        }
    }
}
