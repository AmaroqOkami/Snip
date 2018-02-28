﻿namespace Winter
{
    public partial class Snip
    {
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSnipVersion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSpotify;
        //private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemItunes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWinamp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFoobar2000;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVlc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGPMDP;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuodLibet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetFormat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveSeparateFiles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAlbumArtwork;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKeepSpotifyAlbumArtwork;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSmall;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMedium;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLarge;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCacheSpotifyMetadata;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDisplayTrackPopup;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEmptyFileIfNoTrackPlaying;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEnableHotkeys;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Timer timerScanMediaPlayer;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            if (disposing && (this.keyboardHook != null))
            {
                this.keyboardHook.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSnipVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSpotify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWinamp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFoobar2000 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVlc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGPMDP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuodLibet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSetFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSaveSeparateFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAlbumArtwork = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKeepSpotifyAlbumArtwork = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCacheSpotifyMetadata = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDisplayTrackPopup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEmptyFileIfNoTrackPlaying = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEnableHotkeys = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemStartWithWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerScanMediaPlayer = new System.Windows.Forms.Timer(this.components);
           
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSnipVersion,
            this.toolStripSeparator,
            this.toolStripMenuItemSpotify,
            this.toolStripMenuItemWinamp,
            this.toolStripMenuItemFoobar2000,
            this.toolStripMenuItemVlc,
            this.toolStripMenuItemGPMDP,
            this.toolStripMenuItemQuodLibet,
            this.toolStripSeparator1,
            this.toolStripMenuItemSetFormat,
            this.toolStripSeparator2,
            this.toolStripMenuItemSaveSeparateFiles,
            this.toolStripMenuItemSaveAlbumArtwork,
            this.toolStripMenuItemKeepSpotifyAlbumArtwork,
            this.toolStripMenuItemCacheSpotifyMetadata,
            this.toolStripMenuItemSaveHistory,
            this.toolStripMenuItemDisplayTrackPopup,
            this.toolStripMenuItemEmptyFileIfNoTrackPlaying,
            this.toolStripMenuItemEnableHotkeys,
            this.toolStripSeparator3,
            this.toolStripMenuItemStartWithWindows,
            this.toolStripSeparator4,
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(177, 452);
            // 
            // toolStripMenuItemSnipVersion
            // 
            this.toolStripMenuItemSnipVersion.Enabled = false;
            this.toolStripMenuItemSnipVersion.Name = "toolStripMenuItemSnipVersion";
            this.toolStripMenuItemSnipVersion.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemSnipVersion.Text = Globals.ResourceManager.GetString("SnipForm") + AssemblyInformation.AssemblyShorterVersion;
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItemSpotify
            // 
            this.toolStripMenuItemSpotify.Checked = true;
            this.toolStripMenuItemSpotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemSpotify.Name = "toolStripMenuItemSpotify";
            this.toolStripMenuItemSpotify.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemSpotify.Text = Globals.ResourceManager.GetString("Spotify");
            this.toolStripMenuItemSpotify.Click += new System.EventHandler(this.PlayerSelectionCheck);
            // 
            // toolStripMenuItemWinamp
            // 
            this.toolStripMenuItemWinamp.Name = "toolStripMenuItemWinamp";
            this.toolStripMenuItemWinamp.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemWinamp.Text = Globals.ResourceManager.GetString("Winamp");
            this.toolStripMenuItemWinamp.Click += new System.EventHandler(this.PlayerSelectionCheck);
            // 
            // toolStripMenuItemFoobar2000
            // 
            this.toolStripMenuItemFoobar2000.Name = "toolStripMenuItemFoobar2000";
            this.toolStripMenuItemFoobar2000.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemFoobar2000.Text = Globals.ResourceManager.GetString("foobar2000");
            this.toolStripMenuItemFoobar2000.Click += new System.EventHandler(this.PlayerSelectionCheck);
            // 
            // toolStripMenuItemVlc
            // 
            this.toolStripMenuItemVlc.Name = "toolStripMenuItemVlc";
            this.toolStripMenuItemVlc.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemVlc.Text = Globals.ResourceManager.GetString("VLC");
            this.toolStripMenuItemVlc.Click += new System.EventHandler(this.PlayerSelectionCheck);
            // 
            // toolStripMenuItemGPMDP
            // 
            this.toolStripMenuItemGPMDP.Name = "toolStripMenuItemGPMDP";
            this.toolStripMenuItemGPMDP.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemGPMDP.Text = Globals.ResourceManager.GetString("GPMDP");
            this.toolStripMenuItemGPMDP.Click += new System.EventHandler(this.PlayerSelectionCheck);
            // 
            // toolStripMenuItemQuodLibet
            // 
            this.toolStripMenuItemQuodLibet.Name = "toolStripMenuItemQuodLibet";
            this.toolStripMenuItemQuodLibet.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemQuodLibet.Text = Globals.ResourceManager.GetString("QuodLibet");
            this.toolStripMenuItemQuodLibet.Click += new System.EventHandler(this.PlayerSelectionCheck);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItemSetFormat
            // 
            this.toolStripMenuItemSetFormat.Name = "toolStripMenuItemSetFormat";
            this.toolStripMenuItemSetFormat.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemSetFormat.Text = Globals.ResourceManager.GetString("SetOutputFormat");
            this.toolStripMenuItemSetFormat.Click += new System.EventHandler(this.ToolStripMenuItemSetFormat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItemSaveSeparateFiles
            // 
            this.toolStripMenuItemSaveSeparateFiles.Name = "toolStripMenuItemSaveSeparateFiles";
            this.toolStripMenuItemSaveSeparateFiles.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemSaveSeparateFiles.Text = Globals.ResourceManager.GetString("SaveInformationSeparately");
            this.toolStripMenuItemSaveSeparateFiles.Click += new System.EventHandler(this.ToolStripMenuItemSaveSeparateFiles_Click);
            // 
            // toolStripMenuItemSaveAlbumArtwork
            // 
            this.toolStripMenuItemSaveAlbumArtwork.Name = "toolStripMenuItemSaveAlbumArtwork";
            this.toolStripMenuItemSaveAlbumArtwork.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemSaveAlbumArtwork.Text = Globals.ResourceManager.GetString("SaveAlbumArtwork");
            this.toolStripMenuItemSaveAlbumArtwork.Click += new System.EventHandler(this.ToolStripMenuItemSaveAlbumArtwork_Click);
            // 
            // toolStripMenuItemKeepSpotifyAlbumArtwork
            // 
            this.toolStripMenuItemKeepSpotifyAlbumArtwork.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSmall,
            this.toolStripMenuItemMedium,
            this.toolStripMenuItemLarge});
            this.toolStripMenuItemKeepSpotifyAlbumArtwork.Name = "toolStripMenuItemKeepSpotifyAlbumArtwork";
            this.toolStripMenuItemKeepSpotifyAlbumArtwork.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemKeepSpotifyAlbumArtwork.Text = Globals.ResourceManager.GetString("KeepSpotifyAlbumArtwork");
            this.toolStripMenuItemKeepSpotifyAlbumArtwork.Click += new System.EventHandler(this.ToolStripMenuItemKeepSpotifyAlbumArtwork_Click);
            // 
            // toolStripMenuItemSmall
            // 
            this.toolStripMenuItemSmall.Checked = true;
            this.toolStripMenuItemSmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemSmall.Name = "toolStripMenuItemSmall";
            this.toolStripMenuItemSmall.Size = new System.Drawing.Size(67, 22);
            this.toolStripMenuItemSmall.Text = Globals.ResourceManager.GetString("ImageResolutionSmall");
            this.toolStripMenuItemSmall.Click += new System.EventHandler(this.AlbumArtworkResolutionCheck);
            // 
            // toolStripMenuItemMedium
            // 
            this.toolStripMenuItemMedium.Name = "toolStripMenuItemMedium";
            this.toolStripMenuItemMedium.Size = new System.Drawing.Size(67, 22);
            this.toolStripMenuItemMedium.Text = Globals.ResourceManager.GetString("ImageResolutionMedium");
            this.toolStripMenuItemMedium.Click += new System.EventHandler(this.AlbumArtworkResolutionCheck);
            // 
            // toolStripMenuItemLarge
            // 
            this.toolStripMenuItemLarge.Name = "toolStripMenuItemLarge";
            this.toolStripMenuItemLarge.Size = new System.Drawing.Size(67, 22);
            this.toolStripMenuItemLarge.Text = Globals.ResourceManager.GetString("ImageResolutionLarge");
            this.toolStripMenuItemLarge.Click += new System.EventHandler(this.AlbumArtworkResolutionCheck);
            // 
            // toolStripMenuItemCacheSpotifyMetadata
            // 
            this.toolStripMenuItemCacheSpotifyMetadata.Name = "toolStripMenuItemCacheSpotifyMetadata";
            this.toolStripMenuItemCacheSpotifyMetadata.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemCacheSpotifyMetadata.Text = Globals.ResourceManager.GetString("CacheSpotifyMetadata");
            this.toolStripMenuItemCacheSpotifyMetadata.Click += new System.EventHandler(this.ToolStripMenuItemCacheSpotifyMetadata_Click);
            // 
            // toolStripMenuItemSaveHistory
            // 
            this.toolStripMenuItemSaveHistory.Name = "toolStripMenuItemSaveHistory";
            this.toolStripMenuItemSaveHistory.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemSaveHistory.Text = Globals.ResourceManager.GetString("SaveTrackHistory");
            this.toolStripMenuItemSaveHistory.Click += new System.EventHandler(this.ToolStripMenuItemSaveHistory_Click);
            // 
            // toolStripMenuItemDisplayTrackPopup
            // 
            this.toolStripMenuItemDisplayTrackPopup.Name = "toolStripMenuItemDisplayTrackPopup";
            this.toolStripMenuItemDisplayTrackPopup.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemDisplayTrackPopup.Text = Globals.ResourceManager.GetString("DisplayTrackPopup");
            this.toolStripMenuItemDisplayTrackPopup.Click += new System.EventHandler(this.ToolStripMenuItemDisplayTrackPopup_Click);
            // 
            // toolStripMenuItemEmptyFileIfNoTrackPlaying
            // 
            this.toolStripMenuItemEmptyFileIfNoTrackPlaying.Checked = true;
            this.toolStripMenuItemEmptyFileIfNoTrackPlaying.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemEmptyFileIfNoTrackPlaying.Name = "toolStripMenuItemEmptyFileIfNoTrackPlaying";
            this.toolStripMenuItemEmptyFileIfNoTrackPlaying.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemEmptyFileIfNoTrackPlaying.Text = Globals.ResourceManager.GetString("EmptyFile");
            this.toolStripMenuItemEmptyFileIfNoTrackPlaying.Click += new System.EventHandler(this.ToolStripMenuItemEmptyFileIfNoTrackPlaying_Click);
            // 
            // toolStripMenuItemEnableHotkeys
            // 
            this.toolStripMenuItemEnableHotkeys.Checked = true;
            this.toolStripMenuItemEnableHotkeys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemEnableHotkeys.Name = "toolStripMenuItemEnableHotkeys";
            this.toolStripMenuItemEnableHotkeys.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemEnableHotkeys.Text = Globals.ResourceManager.GetString("EnableHotkeys");
            this.toolStripMenuItemEnableHotkeys.Click += new System.EventHandler(this.ToolStripMenuItemEnableHotkeys_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItemStartWithWindows
            // 
            this.toolStripMenuItemStartWithWindows.Checked = false;
            this.toolStripMenuItemStartWithWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemStartWithWindows.Name = "toolStripMenuItemStartWithWindows";
            this.toolStripMenuItemStartWithWindows.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItemStartWithWindows.Text = "Start with Windows";
            this.toolStripMenuItemStartWithWindows.Click += new System.EventHandler(this.ToolStripMenuItemStartWithWindows_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemExit.Text = Globals.ResourceManager.GetString("ExitApplication");
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // timerScanMediaPlayer
            // 
            this.timerScanMediaPlayer.Tick += new System.EventHandler(this.TimerScanMediaPlayer_Tick);
            // 
            // Snip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = global::Winter.Properties.Resources.SnipIcon;
            this.Name = "Snip";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartWithWindows;
    }
}
