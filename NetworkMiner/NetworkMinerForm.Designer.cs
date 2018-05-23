namespace NetworkMiner {
    partial class NetworkMinerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkMinerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDetectedHosts = new System.Windows.Forms.TabPage();
            this.networkHostTreeView = new System.Windows.Forms.TreeView();
            this.hostMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectHostColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeHostColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hostSortingLabel = new System.Windows.Forms.Label();
            this.hostSortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.detectedHostsTreeRebuildButton = new System.Windows.Forms.Button();
            this.tabPageBrowsers = new System.Windows.Forms.TabPage();
            this.browsersSplitContainer = new System.Windows.Forms.SplitContainer();
            this.httpTransactionTreeView = new System.Windows.Forms.TreeView();
            this.browsersMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAdvertismentColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setInternetTrackerColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectParentNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpTransactionPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.findHttpTransactionTextBox = new System.Windows.Forms.TextBox();
            this.findHttpTransactionCaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.findHttpTransactionButton = new System.Windows.Forms.Button();
            this.findHttpTransactionLabel = new System.Windows.Forms.Label();
            this.tabPageFiles = new System.Windows.Forms.TabPage();
            this.filesListView = new System.Windows.Forms.ListView();
            this.reconstructedFileInitialFrameNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filenameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extensionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sourceHostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sourcePortHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinationHostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinationPortHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.protocolHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reconstructedFileTimestampColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reconstructedFilePathHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filesKeywordFilterControl = new NetworkMiner.KeywordFilterControlForListViewItems();
            this.tabPageImages = new System.Windows.Forms.TabPage();
            this.imagesListView = new System.Windows.Forms.ListView();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.messagesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.messagesListView = new System.Windows.Forms.ListView();
            this.messageFrameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageSourceHostColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageDestinationHostColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageFromColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageToColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageSubjectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageProtocolColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageTimestampColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messagesKeywordFilterControl = new NetworkMiner.KeywordFilterControlForListViewItems();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.messageAttributeListView = new System.Windows.Forms.ListView();
            this.attributeNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attributeValueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageAttachmentListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageEncodingComboBox = new System.Windows.Forms.ComboBox();
            this.tabPageCredentials = new System.Windows.Forms.TabPage();
            this.credentialsListView = new System.Windows.Forms.ListView();
            this.loggedInClientHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serverHostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.protocolStringHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.validHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loginTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.showCookiesCheckBox = new System.Windows.Forms.CheckBox();
            this.maskPasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.showNtlmSspCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPageVoIP = new System.Windows.Forms.TabPage();
            this.voipDataGridView = new System.Windows.Forms.DataGridView();
            this.VoipPlayColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.VoipStopColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.VoipFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoipToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoipStartColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoipDurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoipEncodingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoipCallIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoipSourceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoipDestinationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoipSaveWavColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPageSessions = new System.Windows.Forms.TabPage();
            this.sessionsListView = new System.Windows.Forms.ListView();
            this.sessionFrameNrColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionClientHostColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionClientPortColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionServerHostColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionServerPortColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionProtocolColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionStartTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sessionsKeywordFilterControl = new NetworkMiner.KeywordFilterControlForListViewItems();
            this.tabPageDns = new System.Windows.Forms.TabPage();
            this.dnsListView = new System.Windows.Forms.ListView();
            this.columnHeaderDnsFrameNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsClientPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsServerPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsIpTtl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsDnsTtl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsTransactionId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsRecordType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsQuery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDnsAnswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAlexaTop1M = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dnsKeywordFilterControl = new NetworkMiner.KeywordFilterControlForListViewItems();
            this.tabPageParameters = new System.Windows.Forms.TabPage();
            this.parametersListView = new System.Windows.Forms.ListView();
            this.parameterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parameterValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parameterFrameNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parameterSourceHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parameterSourcePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parameterDestinationHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parameterDestinationPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parameterTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parameterDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parametersContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyParameterNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyParameterValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersKeywordFilterControl = new NetworkMiner.KeywordFilterControlForListViewItems();
            this.tabPageKeywords = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.keywordListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addKeywordsFromFileButton = new System.Windows.Forms.Button();
            this.addKeywordButton = new System.Windows.Forms.Button();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeKeywordButton = new System.Windows.Forms.Button();
            this.detectedKeywordsListView = new System.Windows.Forms.ListView();
            this.columnHeaderFrameNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKeyword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSourceHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSourcePort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDestinationHost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDestinationPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageCleartext = new System.Windows.Forms.TabPage();
            this.cleartextTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeCleartextDictionaryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cleartextSearchModeComboBox = new System.Windows.Forms.ComboBox();
            this.dictionaryNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageReceivedFrames = new System.Windows.Forms.TabPage();
            this.framesTreeView = new System.Windows.Forms.TreeView();
            this.ReceivedFramesClearButton = new System.Windows.Forms.Button();
            this.tabPageAnomalyLog = new System.Windows.Forms.TabPage();
            this.anomalyLog = new System.Windows.Forms.TextBox();
            this.clearAnomaliesButton = new System.Windows.Forms.Button();
            this.casePanelBox = new System.Windows.Forms.GroupBox();
            this.casePanelFileListView = new System.Windows.Forms.ListView();
            this.caseFilenameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.caseMd5Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.caseFileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openParentFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCaseFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedFilesAndReloadCaseFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadCaseFilesButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.snifferBufferToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromPacketCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivePcapOverIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnsRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadRIPEDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startCapturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCapturingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCapturedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getUpgradeCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signWithLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutNetworkMinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkAdaptersComboBox = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new System.Data.DataSet();
            this.openPcapFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.exportDataToFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageDetectedHosts.SuspendLayout();
            this.hostMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageBrowsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browsersSplitContainer)).BeginInit();
            this.browsersSplitContainer.Panel1.SuspendLayout();
            this.browsersSplitContainer.Panel2.SuspendLayout();
            this.browsersSplitContainer.SuspendLayout();
            this.browsersMenuStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            this.tabPageImages.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagesSplitContainer)).BeginInit();
            this.messagesSplitContainer.Panel1.SuspendLayout();
            this.messagesSplitContainer.Panel2.SuspendLayout();
            this.messagesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPageCredentials.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageVoIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voipDataGridView)).BeginInit();
            this.tabPageSessions.SuspendLayout();
            this.tabPageDns.SuspendLayout();
            this.tabPageParameters.SuspendLayout();
            this.parametersContextMenuStrip.SuspendLayout();
            this.tabPageKeywords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageCleartext.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageReceivedFrames.SuspendLayout();
            this.tabPageAnomalyLog.SuspendLayout();
            this.casePanelBox.SuspendLayout();
            this.caseFileContextMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.casePanelBox);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDetectedHosts);
            this.tabControl.Controls.Add(this.tabPageBrowsers);
            this.tabControl.Controls.Add(this.tabPageFiles);
            this.tabControl.Controls.Add(this.tabPageImages);
            this.tabControl.Controls.Add(this.tabPageMessages);
            this.tabControl.Controls.Add(this.tabPageCredentials);
            this.tabControl.Controls.Add(this.tabPageVoIP);
            this.tabControl.Controls.Add(this.tabPageSessions);
            this.tabControl.Controls.Add(this.tabPageDns);
            this.tabControl.Controls.Add(this.tabPageParameters);
            this.tabControl.Controls.Add(this.tabPageKeywords);
            this.tabControl.Controls.Add(this.tabPageCleartext);
            this.tabControl.Controls.Add(this.tabPageReceivedFrames);
            this.tabControl.Controls.Add(this.tabPageAnomalyLog);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPageDetectedHosts
            // 
            this.tabPageDetectedHosts.Controls.Add(this.networkHostTreeView);
            this.tabPageDetectedHosts.Controls.Add(this.panel2);
            resources.ApplyResources(this.tabPageDetectedHosts, "tabPageDetectedHosts");
            this.tabPageDetectedHosts.Name = "tabPageDetectedHosts";
            this.tabPageDetectedHosts.UseVisualStyleBackColor = true;
            // 
            // networkHostTreeView
            // 
            this.networkHostTreeView.ContextMenuStrip = this.hostMenuStrip;
            resources.ApplyResources(this.networkHostTreeView, "networkHostTreeView");
            this.networkHostTreeView.Name = "networkHostTreeView";
            this.networkHostTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.networkHostTreeView_MouseDown);
            // 
            // hostMenuStrip
            // 
            this.hostMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hostMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.copyTextToolStripMenuItem,
            this.selectHostColorMenuItem,
            this.removeHostColorToolStripMenuItem});
            this.hostMenuStrip.Name = "hostColorMenuStrip";
            resources.ApplyResources(this.hostMenuStrip, "hostMenuStrip");
            this.hostMenuStrip.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.hostMenuStrip_Closing);
            this.hostMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.hostColorMenuStrip_Opening);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            resources.ApplyResources(this.expandAllToolStripMenuItem, "expandAllToolStripMenuItem");
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            resources.ApplyResources(this.collapseAllToolStripMenuItem, "collapseAllToolStripMenuItem");
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // copyTextToolStripMenuItem
            // 
            this.copyTextToolStripMenuItem.Name = "copyTextToolStripMenuItem";
            resources.ApplyResources(this.copyTextToolStripMenuItem, "copyTextToolStripMenuItem");
            this.copyTextToolStripMenuItem.Click += new System.EventHandler(this.copyTextToolStripMenuItem_Click);
            // 
            // selectHostColorMenuItem
            // 
            this.selectHostColorMenuItem.Name = "selectHostColorMenuItem";
            resources.ApplyResources(this.selectHostColorMenuItem, "selectHostColorMenuItem");
            this.selectHostColorMenuItem.Click += new System.EventHandler(this.selectHostColorMenuItem_Click);
            // 
            // removeHostColorToolStripMenuItem
            // 
            resources.ApplyResources(this.removeHostColorToolStripMenuItem, "removeHostColorToolStripMenuItem");
            this.removeHostColorToolStripMenuItem.Name = "removeHostColorToolStripMenuItem";
            this.removeHostColorToolStripMenuItem.Click += new System.EventHandler(this.removeHostColorToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hostSortingLabel);
            this.panel2.Controls.Add(this.hostSortOrderComboBox);
            this.panel2.Controls.Add(this.detectedHostsTreeRebuildButton);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // hostSortingLabel
            // 
            resources.ApplyResources(this.hostSortingLabel, "hostSortingLabel");
            this.hostSortingLabel.Name = "hostSortingLabel";
            // 
            // hostSortOrderComboBox
            // 
            resources.ApplyResources(this.hostSortOrderComboBox, "hostSortOrderComboBox");
            this.hostSortOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hostSortOrderComboBox.FormattingEnabled = true;
            this.hostSortOrderComboBox.Items.AddRange(new object[] {
            resources.GetString("hostSortOrderComboBox.Items"),
            resources.GetString("hostSortOrderComboBox.Items1"),
            resources.GetString("hostSortOrderComboBox.Items2"),
            resources.GetString("hostSortOrderComboBox.Items3"),
            resources.GetString("hostSortOrderComboBox.Items4"),
            resources.GetString("hostSortOrderComboBox.Items5"),
            resources.GetString("hostSortOrderComboBox.Items6"),
            resources.GetString("hostSortOrderComboBox.Items7"),
            resources.GetString("hostSortOrderComboBox.Items8"),
            resources.GetString("hostSortOrderComboBox.Items9")});
            this.hostSortOrderComboBox.Name = "hostSortOrderComboBox";
            this.hostSortOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.hostSortOrderComboBox_SelectedIndexChanged);
            // 
            // detectedHostsTreeRebuildButton
            // 
            resources.ApplyResources(this.detectedHostsTreeRebuildButton, "detectedHostsTreeRebuildButton");
            this.detectedHostsTreeRebuildButton.Name = "detectedHostsTreeRebuildButton";
            this.detectedHostsTreeRebuildButton.UseVisualStyleBackColor = true;
            this.detectedHostsTreeRebuildButton.Click += new System.EventHandler(this.detectedHostsTreeRebuildButton_Click);
            // 
            // tabPageBrowsers
            // 
            this.tabPageBrowsers.Controls.Add(this.browsersSplitContainer);
            this.tabPageBrowsers.Controls.Add(this.panel4);
            resources.ApplyResources(this.tabPageBrowsers, "tabPageBrowsers");
            this.tabPageBrowsers.Name = "tabPageBrowsers";
            this.tabPageBrowsers.UseVisualStyleBackColor = true;
            // 
            // browsersSplitContainer
            // 
            resources.ApplyResources(this.browsersSplitContainer, "browsersSplitContainer");
            this.browsersSplitContainer.Name = "browsersSplitContainer";
            // 
            // browsersSplitContainer.Panel1
            // 
            this.browsersSplitContainer.Panel1.Controls.Add(this.httpTransactionTreeView);
            // 
            // browsersSplitContainer.Panel2
            // 
            this.browsersSplitContainer.Panel2.Controls.Add(this.httpTransactionPropertyGrid);
            // 
            // httpTransactionTreeView
            // 
            this.httpTransactionTreeView.ContextMenuStrip = this.browsersMenuStrip;
            resources.ApplyResources(this.httpTransactionTreeView, "httpTransactionTreeView");
            this.httpTransactionTreeView.Name = "httpTransactionTreeView";
            this.httpTransactionTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("httpTransactionTreeView.Nodes")))});
            this.httpTransactionTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.httpTransactionTreeView_AfterSelect);
            this.httpTransactionTreeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.httpTransactionTreeView_KeyDown);
            // 
            // browsersMenuStrip
            // 
            this.browsersMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.browsersMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAdvertismentColorToolStripMenuItem,
            this.setInternetTrackerColorToolStripMenuItem,
            this.toolStripSeparator4,
            this.collapseAllToolStripMenuItem1,
            this.collapseAllButThisToolStripMenuItem,
            this.expandAllToolStripMenuItem1,
            this.findNextToolStripMenuItem,
            this.selectParentNodeToolStripMenuItem});
            this.browsersMenuStrip.Name = "browsersMenuStrip";
            resources.ApplyResources(this.browsersMenuStrip, "browsersMenuStrip");
            // 
            // setAdvertismentColorToolStripMenuItem
            // 
            this.setAdvertismentColorToolStripMenuItem.Name = "setAdvertismentColorToolStripMenuItem";
            resources.ApplyResources(this.setAdvertismentColorToolStripMenuItem, "setAdvertismentColorToolStripMenuItem");
            this.setAdvertismentColorToolStripMenuItem.Click += new System.EventHandler(this.setAdvertismentColorToolStripMenuItem_Click);
            // 
            // setInternetTrackerColorToolStripMenuItem
            // 
            this.setInternetTrackerColorToolStripMenuItem.Name = "setInternetTrackerColorToolStripMenuItem";
            resources.ApplyResources(this.setInternetTrackerColorToolStripMenuItem, "setInternetTrackerColorToolStripMenuItem");
            this.setInternetTrackerColorToolStripMenuItem.Click += new System.EventHandler(this.setInternetTrackerColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // collapseAllToolStripMenuItem1
            // 
            this.collapseAllToolStripMenuItem1.Name = "collapseAllToolStripMenuItem1";
            resources.ApplyResources(this.collapseAllToolStripMenuItem1, "collapseAllToolStripMenuItem1");
            this.collapseAllToolStripMenuItem1.Click += new System.EventHandler(this.collapseAllToolStripMenuItem1_Click);
            // 
            // collapseAllButThisToolStripMenuItem
            // 
            this.collapseAllButThisToolStripMenuItem.Name = "collapseAllButThisToolStripMenuItem";
            resources.ApplyResources(this.collapseAllButThisToolStripMenuItem, "collapseAllButThisToolStripMenuItem");
            this.collapseAllButThisToolStripMenuItem.Click += new System.EventHandler(this.collapseAllButThisToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem1
            // 
            this.expandAllToolStripMenuItem1.Name = "expandAllToolStripMenuItem1";
            resources.ApplyResources(this.expandAllToolStripMenuItem1, "expandAllToolStripMenuItem1");
            this.expandAllToolStripMenuItem1.Click += new System.EventHandler(this.expandAllToolStripMenuItem1_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            resources.ApplyResources(this.findNextToolStripMenuItem, "findNextToolStripMenuItem");
            this.findNextToolStripMenuItem.Click += new System.EventHandler(this.findNextToolStripMenuItem_Click);
            // 
            // selectParentNodeToolStripMenuItem
            // 
            this.selectParentNodeToolStripMenuItem.Name = "selectParentNodeToolStripMenuItem";
            resources.ApplyResources(this.selectParentNodeToolStripMenuItem, "selectParentNodeToolStripMenuItem");
            this.selectParentNodeToolStripMenuItem.Click += new System.EventHandler(this.selectParentNodeToolStripMenuItem_Click);
            // 
            // httpTransactionPropertyGrid
            // 
            resources.ApplyResources(this.httpTransactionPropertyGrid, "httpTransactionPropertyGrid");
            this.httpTransactionPropertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            this.httpTransactionPropertyGrid.Name = "httpTransactionPropertyGrid";
            this.httpTransactionPropertyGrid.ToolbarVisible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.findHttpTransactionTextBox);
            this.panel4.Controls.Add(this.findHttpTransactionCaseSensitiveCheckBox);
            this.panel4.Controls.Add(this.findHttpTransactionButton);
            this.panel4.Controls.Add(this.findHttpTransactionLabel);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // findHttpTransactionTextBox
            // 
            resources.ApplyResources(this.findHttpTransactionTextBox, "findHttpTransactionTextBox");
            this.findHttpTransactionTextBox.Name = "findHttpTransactionTextBox";
            this.findHttpTransactionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findHttpTransactionTextBox_KeyDown);
            // 
            // findHttpTransactionCaseSensitiveCheckBox
            // 
            resources.ApplyResources(this.findHttpTransactionCaseSensitiveCheckBox, "findHttpTransactionCaseSensitiveCheckBox");
            this.findHttpTransactionCaseSensitiveCheckBox.Name = "findHttpTransactionCaseSensitiveCheckBox";
            this.findHttpTransactionCaseSensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // findHttpTransactionButton
            // 
            resources.ApplyResources(this.findHttpTransactionButton, "findHttpTransactionButton");
            this.findHttpTransactionButton.Name = "findHttpTransactionButton";
            this.findHttpTransactionButton.UseVisualStyleBackColor = true;
            this.findHttpTransactionButton.Click += new System.EventHandler(this.findHttpTransactionButton_Click);
            // 
            // findHttpTransactionLabel
            // 
            resources.ApplyResources(this.findHttpTransactionLabel, "findHttpTransactionLabel");
            this.findHttpTransactionLabel.Name = "findHttpTransactionLabel";
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.filesListView);
            this.tabPageFiles.Controls.Add(this.filesKeywordFilterControl);
            resources.ApplyResources(this.tabPageFiles, "tabPageFiles");
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // filesListView
            // 
            this.filesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reconstructedFileInitialFrameNumber,
            this.filenameHeader,
            this.extensionHeader,
            this.fileSizeHeader,
            this.sourceHostHeader,
            this.sourcePortHeader,
            this.destinationHostHeader,
            this.destinationPortHeader,
            this.protocolHeader,
            this.reconstructedFileTimestampColumnHeader,
            this.reconstructedFilePathHeader,
            this.detailsHeader});
            resources.ApplyResources(this.filesListView, "filesListView");
            this.filesListView.FullRowSelect = true;
            this.filesListView.HideSelection = false;
            this.filesListView.MultiSelect = false;
            this.filesListView.Name = "filesListView";
            this.filesListView.ShowItemToolTips = true;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            this.filesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            this.filesListView.SelectedIndexChanged += new System.EventHandler(this.filesListView_SelectedIndexChanged);
            this.filesListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filesListView_MouseDown);
            // 
            // reconstructedFileInitialFrameNumber
            // 
            resources.ApplyResources(this.reconstructedFileInitialFrameNumber, "reconstructedFileInitialFrameNumber");
            // 
            // filenameHeader
            // 
            resources.ApplyResources(this.filenameHeader, "filenameHeader");
            // 
            // extensionHeader
            // 
            resources.ApplyResources(this.extensionHeader, "extensionHeader");
            // 
            // fileSizeHeader
            // 
            resources.ApplyResources(this.fileSizeHeader, "fileSizeHeader");
            // 
            // sourceHostHeader
            // 
            resources.ApplyResources(this.sourceHostHeader, "sourceHostHeader");
            // 
            // sourcePortHeader
            // 
            resources.ApplyResources(this.sourcePortHeader, "sourcePortHeader");
            // 
            // destinationHostHeader
            // 
            resources.ApplyResources(this.destinationHostHeader, "destinationHostHeader");
            // 
            // destinationPortHeader
            // 
            resources.ApplyResources(this.destinationPortHeader, "destinationPortHeader");
            // 
            // protocolHeader
            // 
            resources.ApplyResources(this.protocolHeader, "protocolHeader");
            // 
            // reconstructedFileTimestampColumnHeader
            // 
            resources.ApplyResources(this.reconstructedFileTimestampColumnHeader, "reconstructedFileTimestampColumnHeader");
            // 
            // reconstructedFilePathHeader
            // 
            resources.ApplyResources(this.reconstructedFilePathHeader, "reconstructedFilePathHeader");
            // 
            // detailsHeader
            // 
            resources.ApplyResources(this.detailsHeader, "detailsHeader");
            // 
            // filesKeywordFilterControl
            // 
            resources.ApplyResources(this.filesKeywordFilterControl, "filesKeywordFilterControl");
            this.filesKeywordFilterControl.Name = "filesKeywordFilterControl";
            // 
            // tabPageImages
            // 
            this.tabPageImages.Controls.Add(this.imagesListView);
            resources.ApplyResources(this.tabPageImages, "tabPageImages");
            this.tabPageImages.Name = "tabPageImages";
            this.tabPageImages.UseVisualStyleBackColor = true;
            // 
            // imagesListView
            // 
            resources.ApplyResources(this.imagesListView, "imagesListView");
            this.imagesListView.Name = "imagesListView";
            this.imagesListView.ShowItemToolTips = true;
            this.imagesListView.UseCompatibleStateImageBehavior = false;
            this.imagesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imagesListView_MouseDoubleClick);
            this.imagesListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagesListView_MouseDown);
            this.imagesListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagesListView_MouseMove);
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.messagesSplitContainer);
            resources.ApplyResources(this.tabPageMessages, "tabPageMessages");
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // messagesSplitContainer
            // 
            resources.ApplyResources(this.messagesSplitContainer, "messagesSplitContainer");
            this.messagesSplitContainer.Name = "messagesSplitContainer";
            // 
            // messagesSplitContainer.Panel1
            // 
            this.messagesSplitContainer.Panel1.Controls.Add(this.messagesListView);
            this.messagesSplitContainer.Panel1.Controls.Add(this.messagesKeywordFilterControl);
            // 
            // messagesSplitContainer.Panel2
            // 
            this.messagesSplitContainer.Panel2.Controls.Add(this.splitContainer3);
            // 
            // messagesListView
            // 
            this.messagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.messageFrameColumnHeader,
            this.messageSourceHostColumnHeader,
            this.messageDestinationHostColumnHeader,
            this.messageFromColumnHeader,
            this.messageToColumnHeader,
            this.messageSubjectColumnHeader,
            this.messageProtocolColumnHeader,
            this.messageTimestampColumnHeader});
            resources.ApplyResources(this.messagesListView, "messagesListView");
            this.messagesListView.FullRowSelect = true;
            this.messagesListView.MultiSelect = false;
            this.messagesListView.Name = "messagesListView";
            this.messagesListView.ShowItemToolTips = true;
            this.messagesListView.UseCompatibleStateImageBehavior = false;
            this.messagesListView.View = System.Windows.Forms.View.Details;
            this.messagesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            this.messagesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.messagesListView_ItemSelectionChanged);
            // 
            // messageFrameColumnHeader
            // 
            resources.ApplyResources(this.messageFrameColumnHeader, "messageFrameColumnHeader");
            // 
            // messageSourceHostColumnHeader
            // 
            resources.ApplyResources(this.messageSourceHostColumnHeader, "messageSourceHostColumnHeader");
            // 
            // messageDestinationHostColumnHeader
            // 
            resources.ApplyResources(this.messageDestinationHostColumnHeader, "messageDestinationHostColumnHeader");
            // 
            // messageFromColumnHeader
            // 
            resources.ApplyResources(this.messageFromColumnHeader, "messageFromColumnHeader");
            // 
            // messageToColumnHeader
            // 
            resources.ApplyResources(this.messageToColumnHeader, "messageToColumnHeader");
            // 
            // messageSubjectColumnHeader
            // 
            resources.ApplyResources(this.messageSubjectColumnHeader, "messageSubjectColumnHeader");
            // 
            // messageProtocolColumnHeader
            // 
            resources.ApplyResources(this.messageProtocolColumnHeader, "messageProtocolColumnHeader");
            // 
            // messageTimestampColumnHeader
            // 
            resources.ApplyResources(this.messageTimestampColumnHeader, "messageTimestampColumnHeader");
            // 
            // messagesKeywordFilterControl
            // 
            resources.ApplyResources(this.messagesKeywordFilterControl, "messagesKeywordFilterControl");
            this.messagesKeywordFilterControl.Name = "messagesKeywordFilterControl";
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.messageAttributeListView);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2.Controls.Add(this.messageEncodingComboBox);
            // 
            // messageAttributeListView
            // 
            this.messageAttributeListView.BackColor = System.Drawing.SystemColors.Control;
            this.messageAttributeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.attributeNameColumnHeader,
            this.attributeValueColumnHeader});
            resources.ApplyResources(this.messageAttributeListView, "messageAttributeListView");
            this.messageAttributeListView.FullRowSelect = true;
            this.messageAttributeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.messageAttributeListView.Name = "messageAttributeListView";
            this.messageAttributeListView.ShowItemToolTips = true;
            this.messageAttributeListView.UseCompatibleStateImageBehavior = false;
            this.messageAttributeListView.View = System.Windows.Forms.View.Details;
            // 
            // attributeNameColumnHeader
            // 
            resources.ApplyResources(this.attributeNameColumnHeader, "attributeNameColumnHeader");
            // 
            // attributeValueColumnHeader
            // 
            resources.ApplyResources(this.attributeValueColumnHeader, "attributeValueColumnHeader");
            // 
            // splitContainer4
            // 
            resources.ApplyResources(this.splitContainer4, "splitContainer4");
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.messageTextBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.messageAttachmentListView);
            // 
            // messageTextBox
            // 
            resources.ApplyResources(this.messageTextBox, "messageTextBox");
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            // 
            // messageAttachmentListView
            // 
            this.messageAttachmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            resources.ApplyResources(this.messageAttachmentListView, "messageAttachmentListView");
            this.messageAttachmentListView.FullRowSelect = true;
            this.messageAttachmentListView.MultiSelect = false;
            this.messageAttachmentListView.Name = "messageAttachmentListView";
            this.messageAttachmentListView.ShowItemToolTips = true;
            this.messageAttachmentListView.UseCompatibleStateImageBehavior = false;
            this.messageAttachmentListView.View = System.Windows.Forms.View.Details;
            this.messageAttachmentListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.messageAttachmentListView_MouseDown);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // messageEncodingComboBox
            // 
            resources.ApplyResources(this.messageEncodingComboBox, "messageEncodingComboBox");
            this.messageEncodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.messageEncodingComboBox.FormattingEnabled = true;
            this.messageEncodingComboBox.Name = "messageEncodingComboBox";
            this.messageEncodingComboBox.SelectedIndexChanged += new System.EventHandler(this.messageEncodingComboBox_SelectedIndexChanged);
            // 
            // tabPageCredentials
            // 
            this.tabPageCredentials.Controls.Add(this.credentialsListView);
            this.tabPageCredentials.Controls.Add(this.panel3);
            resources.ApplyResources(this.tabPageCredentials, "tabPageCredentials");
            this.tabPageCredentials.Name = "tabPageCredentials";
            this.tabPageCredentials.UseVisualStyleBackColor = true;
            // 
            // credentialsListView
            // 
            this.credentialsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.loggedInClientHeader,
            this.serverHostHeader,
            this.protocolStringHeader,
            this.usernameHeader,
            this.passwordHeader,
            this.validHeader,
            this.loginTimestamp});
            resources.ApplyResources(this.credentialsListView, "credentialsListView");
            this.credentialsListView.FullRowSelect = true;
            this.credentialsListView.HideSelection = false;
            this.credentialsListView.Name = "credentialsListView";
            this.credentialsListView.ShowItemToolTips = true;
            this.credentialsListView.UseCompatibleStateImageBehavior = false;
            this.credentialsListView.View = System.Windows.Forms.View.Details;
            this.credentialsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            // 
            // loggedInClientHeader
            // 
            resources.ApplyResources(this.loggedInClientHeader, "loggedInClientHeader");
            // 
            // serverHostHeader
            // 
            resources.ApplyResources(this.serverHostHeader, "serverHostHeader");
            // 
            // protocolStringHeader
            // 
            resources.ApplyResources(this.protocolStringHeader, "protocolStringHeader");
            // 
            // usernameHeader
            // 
            resources.ApplyResources(this.usernameHeader, "usernameHeader");
            // 
            // passwordHeader
            // 
            resources.ApplyResources(this.passwordHeader, "passwordHeader");
            // 
            // validHeader
            // 
            resources.ApplyResources(this.validHeader, "validHeader");
            // 
            // loginTimestamp
            // 
            resources.ApplyResources(this.loginTimestamp, "loginTimestamp");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.showCookiesCheckBox);
            this.panel3.Controls.Add(this.maskPasswordsCheckBox);
            this.panel3.Controls.Add(this.showNtlmSspCheckBox);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // showCookiesCheckBox
            // 
            resources.ApplyResources(this.showCookiesCheckBox, "showCookiesCheckBox");
            this.showCookiesCheckBox.Checked = true;
            this.showCookiesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCookiesCheckBox.Name = "showCookiesCheckBox";
            this.showCookiesCheckBox.UseVisualStyleBackColor = true;
            this.showCookiesCheckBox.CheckedChanged += new System.EventHandler(this.credentialsSettingsCheckBox_Click);
            // 
            // maskPasswordsCheckBox
            // 
            resources.ApplyResources(this.maskPasswordsCheckBox, "maskPasswordsCheckBox");
            this.maskPasswordsCheckBox.Name = "maskPasswordsCheckBox";
            this.maskPasswordsCheckBox.UseVisualStyleBackColor = true;
            this.maskPasswordsCheckBox.CheckedChanged += new System.EventHandler(this.credentialsSettingsCheckBox_Click);
            // 
            // showNtlmSspCheckBox
            // 
            resources.ApplyResources(this.showNtlmSspCheckBox, "showNtlmSspCheckBox");
            this.showNtlmSspCheckBox.Checked = true;
            this.showNtlmSspCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showNtlmSspCheckBox.Name = "showNtlmSspCheckBox";
            this.showNtlmSspCheckBox.UseVisualStyleBackColor = true;
            this.showNtlmSspCheckBox.CheckedChanged += new System.EventHandler(this.credentialsSettingsCheckBox_Click);
            // 
            // tabPageVoIP
            // 
            this.tabPageVoIP.Controls.Add(this.voipDataGridView);
            resources.ApplyResources(this.tabPageVoIP, "tabPageVoIP");
            this.tabPageVoIP.Name = "tabPageVoIP";
            this.tabPageVoIP.UseVisualStyleBackColor = true;
            // 
            // voipDataGridView
            // 
            this.voipDataGridView.AllowUserToAddRows = false;
            this.voipDataGridView.AllowUserToDeleteRows = false;
            this.voipDataGridView.AllowUserToOrderColumns = true;
            this.voipDataGridView.AllowUserToResizeRows = false;
            this.voipDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voipDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoipPlayColumn,
            this.VoipStopColumn,
            this.VoipFromColumn,
            this.VoipToColumn,
            this.VoipStartColumn,
            this.VoipDurationColumn,
            this.VoipEncodingColumn,
            this.VoipCallIDColumn,
            this.VoipSourceColumn,
            this.VoipDestinationColumn,
            this.VoipSaveWavColumn});
            resources.ApplyResources(this.voipDataGridView, "voipDataGridView");
            this.voipDataGridView.Name = "voipDataGridView";
            this.voipDataGridView.ReadOnly = true;
            this.voipDataGridView.RowHeadersVisible = false;
            this.voipDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.voipDataGridView.ShowEditingIcon = false;
            this.voipDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.voipDataGridView_CellContentClick);
            this.voipDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.voipDataGridView_KeyDown);
            // 
            // VoipPlayColumn
            // 
            this.VoipPlayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.VoipPlayColumn.Frozen = true;
            resources.ApplyResources(this.VoipPlayColumn, "VoipPlayColumn");
            this.VoipPlayColumn.Name = "VoipPlayColumn";
            this.VoipPlayColumn.ReadOnly = true;
            this.VoipPlayColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VoipStopColumn
            // 
            this.VoipStopColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.VoipStopColumn.Frozen = true;
            resources.ApplyResources(this.VoipStopColumn, "VoipStopColumn");
            this.VoipStopColumn.Name = "VoipStopColumn";
            this.VoipStopColumn.ReadOnly = true;
            this.VoipStopColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VoipFromColumn
            // 
            this.VoipFromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipFromColumn, "VoipFromColumn");
            this.VoipFromColumn.Name = "VoipFromColumn";
            this.VoipFromColumn.ReadOnly = true;
            // 
            // VoipToColumn
            // 
            this.VoipToColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipToColumn, "VoipToColumn");
            this.VoipToColumn.Name = "VoipToColumn";
            this.VoipToColumn.ReadOnly = true;
            // 
            // VoipStartColumn
            // 
            this.VoipStartColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipStartColumn, "VoipStartColumn");
            this.VoipStartColumn.Name = "VoipStartColumn";
            this.VoipStartColumn.ReadOnly = true;
            // 
            // VoipDurationColumn
            // 
            this.VoipDurationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipDurationColumn, "VoipDurationColumn");
            this.VoipDurationColumn.Name = "VoipDurationColumn";
            this.VoipDurationColumn.ReadOnly = true;
            // 
            // VoipEncodingColumn
            // 
            this.VoipEncodingColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipEncodingColumn, "VoipEncodingColumn");
            this.VoipEncodingColumn.Name = "VoipEncodingColumn";
            this.VoipEncodingColumn.ReadOnly = true;
            // 
            // VoipCallIDColumn
            // 
            this.VoipCallIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipCallIDColumn, "VoipCallIDColumn");
            this.VoipCallIDColumn.Name = "VoipCallIDColumn";
            this.VoipCallIDColumn.ReadOnly = true;
            // 
            // VoipSourceColumn
            // 
            this.VoipSourceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipSourceColumn, "VoipSourceColumn");
            this.VoipSourceColumn.Name = "VoipSourceColumn";
            this.VoipSourceColumn.ReadOnly = true;
            // 
            // VoipDestinationColumn
            // 
            this.VoipDestinationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipDestinationColumn, "VoipDestinationColumn");
            this.VoipDestinationColumn.Name = "VoipDestinationColumn";
            this.VoipDestinationColumn.ReadOnly = true;
            // 
            // VoipSaveWavColumn
            // 
            this.VoipSaveWavColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.VoipSaveWavColumn, "VoipSaveWavColumn");
            this.VoipSaveWavColumn.Name = "VoipSaveWavColumn";
            this.VoipSaveWavColumn.ReadOnly = true;
            this.VoipSaveWavColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tabPageSessions
            // 
            this.tabPageSessions.Controls.Add(this.sessionsListView);
            this.tabPageSessions.Controls.Add(this.sessionsKeywordFilterControl);
            resources.ApplyResources(this.tabPageSessions, "tabPageSessions");
            this.tabPageSessions.Name = "tabPageSessions";
            this.tabPageSessions.UseVisualStyleBackColor = true;
            // 
            // sessionsListView
            // 
            this.sessionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sessionFrameNrColumnHeader,
            this.sessionClientHostColumnHeader,
            this.sessionClientPortColumnHeader,
            this.sessionServerHostColumnHeader,
            this.sessionServerPortColumnHeader,
            this.sessionProtocolColumnHeader,
            this.sessionStartTimeColumnHeader});
            resources.ApplyResources(this.sessionsListView, "sessionsListView");
            this.sessionsListView.FullRowSelect = true;
            this.sessionsListView.MultiSelect = false;
            this.sessionsListView.Name = "sessionsListView";
            this.sessionsListView.UseCompatibleStateImageBehavior = false;
            this.sessionsListView.View = System.Windows.Forms.View.Details;
            this.sessionsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            // 
            // sessionFrameNrColumnHeader
            // 
            resources.ApplyResources(this.sessionFrameNrColumnHeader, "sessionFrameNrColumnHeader");
            // 
            // sessionClientHostColumnHeader
            // 
            resources.ApplyResources(this.sessionClientHostColumnHeader, "sessionClientHostColumnHeader");
            // 
            // sessionClientPortColumnHeader
            // 
            resources.ApplyResources(this.sessionClientPortColumnHeader, "sessionClientPortColumnHeader");
            // 
            // sessionServerHostColumnHeader
            // 
            resources.ApplyResources(this.sessionServerHostColumnHeader, "sessionServerHostColumnHeader");
            // 
            // sessionServerPortColumnHeader
            // 
            resources.ApplyResources(this.sessionServerPortColumnHeader, "sessionServerPortColumnHeader");
            // 
            // sessionProtocolColumnHeader
            // 
            resources.ApplyResources(this.sessionProtocolColumnHeader, "sessionProtocolColumnHeader");
            // 
            // sessionStartTimeColumnHeader
            // 
            resources.ApplyResources(this.sessionStartTimeColumnHeader, "sessionStartTimeColumnHeader");
            // 
            // sessionsKeywordFilterControl
            // 
            resources.ApplyResources(this.sessionsKeywordFilterControl, "sessionsKeywordFilterControl");
            this.sessionsKeywordFilterControl.Name = "sessionsKeywordFilterControl";
            // 
            // tabPageDns
            // 
            this.tabPageDns.Controls.Add(this.dnsListView);
            this.tabPageDns.Controls.Add(this.dnsKeywordFilterControl);
            resources.ApplyResources(this.tabPageDns, "tabPageDns");
            this.tabPageDns.Name = "tabPageDns";
            this.tabPageDns.UseVisualStyleBackColor = true;
            // 
            // dnsListView
            // 
            this.dnsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDnsFrameNumber,
            this.columnHeaderDnsTimestamp,
            this.columnHeaderDnsClient,
            this.columnHeaderDnsClientPort,
            this.columnHeaderDnsServer,
            this.columnHeaderDnsServerPort,
            this.columnHeaderDnsIpTtl,
            this.columnHeaderDnsDnsTtl,
            this.columnHeaderDnsTransactionId,
            this.columnHeaderDnsRecordType,
            this.columnHeaderDnsQuery,
            this.columnHeaderDnsAnswer,
            this.columnHeaderAlexaTop1M});
            resources.ApplyResources(this.dnsListView, "dnsListView");
            this.dnsListView.FullRowSelect = true;
            this.dnsListView.HideSelection = false;
            this.dnsListView.Name = "dnsListView";
            this.dnsListView.ShowItemToolTips = true;
            this.dnsListView.UseCompatibleStateImageBehavior = false;
            this.dnsListView.View = System.Windows.Forms.View.Details;
            this.dnsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            // 
            // columnHeaderDnsFrameNumber
            // 
            resources.ApplyResources(this.columnHeaderDnsFrameNumber, "columnHeaderDnsFrameNumber");
            // 
            // columnHeaderDnsTimestamp
            // 
            resources.ApplyResources(this.columnHeaderDnsTimestamp, "columnHeaderDnsTimestamp");
            // 
            // columnHeaderDnsClient
            // 
            resources.ApplyResources(this.columnHeaderDnsClient, "columnHeaderDnsClient");
            // 
            // columnHeaderDnsClientPort
            // 
            resources.ApplyResources(this.columnHeaderDnsClientPort, "columnHeaderDnsClientPort");
            // 
            // columnHeaderDnsServer
            // 
            resources.ApplyResources(this.columnHeaderDnsServer, "columnHeaderDnsServer");
            // 
            // columnHeaderDnsServerPort
            // 
            resources.ApplyResources(this.columnHeaderDnsServerPort, "columnHeaderDnsServerPort");
            // 
            // columnHeaderDnsIpTtl
            // 
            resources.ApplyResources(this.columnHeaderDnsIpTtl, "columnHeaderDnsIpTtl");
            // 
            // columnHeaderDnsDnsTtl
            // 
            resources.ApplyResources(this.columnHeaderDnsDnsTtl, "columnHeaderDnsDnsTtl");
            // 
            // columnHeaderDnsTransactionId
            // 
            resources.ApplyResources(this.columnHeaderDnsTransactionId, "columnHeaderDnsTransactionId");
            // 
            // columnHeaderDnsRecordType
            // 
            resources.ApplyResources(this.columnHeaderDnsRecordType, "columnHeaderDnsRecordType");
            // 
            // columnHeaderDnsQuery
            // 
            resources.ApplyResources(this.columnHeaderDnsQuery, "columnHeaderDnsQuery");
            // 
            // columnHeaderDnsAnswer
            // 
            resources.ApplyResources(this.columnHeaderDnsAnswer, "columnHeaderDnsAnswer");
            // 
            // columnHeaderAlexaTop1M
            // 
            resources.ApplyResources(this.columnHeaderAlexaTop1M, "columnHeaderAlexaTop1M");
            // 
            // dnsKeywordFilterControl
            // 
            resources.ApplyResources(this.dnsKeywordFilterControl, "dnsKeywordFilterControl");
            this.dnsKeywordFilterControl.Name = "dnsKeywordFilterControl";
            // 
            // tabPageParameters
            // 
            this.tabPageParameters.Controls.Add(this.parametersListView);
            this.tabPageParameters.Controls.Add(this.parametersKeywordFilterControl);
            this.tabPageParameters.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.tabPageParameters, "tabPageParameters");
            this.tabPageParameters.Name = "tabPageParameters";
            this.tabPageParameters.UseVisualStyleBackColor = true;
            // 
            // parametersListView
            // 
            this.parametersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.parameterName,
            this.parameterValue,
            this.parameterFrameNumber,
            this.parameterSourceHost,
            this.parameterSourcePort,
            this.parameterDestinationHost,
            this.parameterDestinationPort,
            this.parameterTimestamp,
            this.parameterDetails});
            this.parametersListView.ContextMenuStrip = this.parametersContextMenuStrip;
            resources.ApplyResources(this.parametersListView, "parametersListView");
            this.parametersListView.FullRowSelect = true;
            this.parametersListView.Name = "parametersListView";
            this.parametersListView.UseCompatibleStateImageBehavior = false;
            this.parametersListView.View = System.Windows.Forms.View.Details;
            this.parametersListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            // 
            // parameterName
            // 
            resources.ApplyResources(this.parameterName, "parameterName");
            // 
            // parameterValue
            // 
            resources.ApplyResources(this.parameterValue, "parameterValue");
            // 
            // parameterFrameNumber
            // 
            resources.ApplyResources(this.parameterFrameNumber, "parameterFrameNumber");
            // 
            // parameterSourceHost
            // 
            resources.ApplyResources(this.parameterSourceHost, "parameterSourceHost");
            // 
            // parameterSourcePort
            // 
            resources.ApplyResources(this.parameterSourcePort, "parameterSourcePort");
            // 
            // parameterDestinationHost
            // 
            resources.ApplyResources(this.parameterDestinationHost, "parameterDestinationHost");
            // 
            // parameterDestinationPort
            // 
            resources.ApplyResources(this.parameterDestinationPort, "parameterDestinationPort");
            // 
            // parameterTimestamp
            // 
            resources.ApplyResources(this.parameterTimestamp, "parameterTimestamp");
            // 
            // parameterDetails
            // 
            resources.ApplyResources(this.parameterDetails, "parameterDetails");
            // 
            // parametersContextMenuStrip
            // 
            this.parametersContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.parametersContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyParameterNameToolStripMenuItem,
            this.copyParameterValueToolStripMenuItem});
            this.parametersContextMenuStrip.Name = "parametersContextMenuStrip";
            resources.ApplyResources(this.parametersContextMenuStrip, "parametersContextMenuStrip");
            // 
            // copyParameterNameToolStripMenuItem
            // 
            this.copyParameterNameToolStripMenuItem.Name = "copyParameterNameToolStripMenuItem";
            resources.ApplyResources(this.copyParameterNameToolStripMenuItem, "copyParameterNameToolStripMenuItem");
            this.copyParameterNameToolStripMenuItem.Click += new System.EventHandler(this.copyParameterNameToolStripMenuItem_Click);
            // 
            // copyParameterValueToolStripMenuItem
            // 
            this.copyParameterValueToolStripMenuItem.Name = "copyParameterValueToolStripMenuItem";
            resources.ApplyResources(this.copyParameterValueToolStripMenuItem, "copyParameterValueToolStripMenuItem");
            this.copyParameterValueToolStripMenuItem.Click += new System.EventHandler(this.copyParameterValueToolStripMenuItem_Click);
            // 
            // parametersKeywordFilterControl
            // 
            resources.ApplyResources(this.parametersKeywordFilterControl, "parametersKeywordFilterControl");
            this.parametersKeywordFilterControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parametersKeywordFilterControl.Name = "parametersKeywordFilterControl";
            // 
            // tabPageKeywords
            // 
            this.tabPageKeywords.Controls.Add(this.splitContainer2);
            resources.ApplyResources(this.tabPageKeywords, "tabPageKeywords");
            this.tabPageKeywords.Name = "tabPageKeywords";
            this.tabPageKeywords.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.keywordListBox);
            this.splitContainer2.Panel1.Controls.Add(this.panel5);
            this.splitContainer2.Panel1.Controls.Add(this.removeKeywordButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.detectedKeywordsListView);
            // 
            // keywordListBox
            // 
            resources.ApplyResources(this.keywordListBox, "keywordListBox");
            this.keywordListBox.FormattingEnabled = true;
            this.keywordListBox.Name = "keywordListBox";
            this.keywordListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.keywordListBox.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.keywordListBox_ControlAdded);
            this.keywordListBox.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.keywordListBox_ControlRemoved);
            this.keywordListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keywordListBox_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.addKeywordsFromFileButton);
            this.panel5.Controls.Add(this.addKeywordButton);
            this.panel5.Controls.Add(this.keywordTextBox);
            this.panel5.Controls.Add(this.label1);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // addKeywordsFromFileButton
            // 
            resources.ApplyResources(this.addKeywordsFromFileButton, "addKeywordsFromFileButton");
            this.addKeywordsFromFileButton.Image = global::NetworkMiner.Properties.Resources.openHS;
            this.addKeywordsFromFileButton.Name = "addKeywordsFromFileButton";
            this.addKeywordsFromFileButton.UseVisualStyleBackColor = true;
            this.addKeywordsFromFileButton.Click += new System.EventHandler(this.addKeywordsFromFileButton_Click);
            // 
            // addKeywordButton
            // 
            resources.ApplyResources(this.addKeywordButton, "addKeywordButton");
            this.addKeywordButton.Name = "addKeywordButton";
            this.addKeywordButton.UseVisualStyleBackColor = true;
            this.addKeywordButton.Click += new System.EventHandler(this.addKeyword);
            // 
            // keywordTextBox
            // 
            resources.ApplyResources(this.keywordTextBox, "keywordTextBox");
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keywordTextBox_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // removeKeywordButton
            // 
            resources.ApplyResources(this.removeKeywordButton, "removeKeywordButton");
            this.removeKeywordButton.Name = "removeKeywordButton";
            this.removeKeywordButton.UseVisualStyleBackColor = true;
            this.removeKeywordButton.Click += new System.EventHandler(this.removeKeywordButton_Click);
            // 
            // detectedKeywordsListView
            // 
            this.detectedKeywordsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFrameNr,
            this.columnHeaderTimestamp,
            this.columnHeaderKeyword,
            this.columnHeaderContext,
            this.columnHeaderSourceHost,
            this.columnHeaderSourcePort,
            this.columnDestinationHost,
            this.columnHeaderDestinationPort});
            resources.ApplyResources(this.detectedKeywordsListView, "detectedKeywordsListView");
            this.detectedKeywordsListView.FullRowSelect = true;
            this.detectedKeywordsListView.Name = "detectedKeywordsListView";
            this.detectedKeywordsListView.UseCompatibleStateImageBehavior = false;
            this.detectedKeywordsListView.View = System.Windows.Forms.View.Details;
            this.detectedKeywordsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewColumnClick);
            // 
            // columnHeaderFrameNr
            // 
            resources.ApplyResources(this.columnHeaderFrameNr, "columnHeaderFrameNr");
            // 
            // columnHeaderTimestamp
            // 
            resources.ApplyResources(this.columnHeaderTimestamp, "columnHeaderTimestamp");
            // 
            // columnHeaderKeyword
            // 
            resources.ApplyResources(this.columnHeaderKeyword, "columnHeaderKeyword");
            // 
            // columnHeaderContext
            // 
            resources.ApplyResources(this.columnHeaderContext, "columnHeaderContext");
            // 
            // columnHeaderSourceHost
            // 
            resources.ApplyResources(this.columnHeaderSourceHost, "columnHeaderSourceHost");
            // 
            // columnHeaderSourcePort
            // 
            resources.ApplyResources(this.columnHeaderSourcePort, "columnHeaderSourcePort");
            // 
            // columnDestinationHost
            // 
            resources.ApplyResources(this.columnDestinationHost, "columnDestinationHost");
            // 
            // columnHeaderDestinationPort
            // 
            resources.ApplyResources(this.columnHeaderDestinationPort, "columnHeaderDestinationPort");
            // 
            // tabPageCleartext
            // 
            this.tabPageCleartext.Controls.Add(this.cleartextTextBox);
            this.tabPageCleartext.Controls.Add(this.panel1);
            this.tabPageCleartext.Controls.Add(this.button1);
            resources.ApplyResources(this.tabPageCleartext, "tabPageCleartext");
            this.tabPageCleartext.Name = "tabPageCleartext";
            this.tabPageCleartext.UseVisualStyleBackColor = true;
            // 
            // cleartextTextBox
            // 
            resources.ApplyResources(this.cleartextTextBox, "cleartextTextBox");
            this.cleartextTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cleartextTextBox.Name = "cleartextTextBox";
            this.cleartextTextBox.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeCleartextDictionaryButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cleartextSearchModeComboBox);
            this.panel1.Controls.Add(this.dictionaryNameLabel);
            this.panel1.Controls.Add(this.label5);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // changeCleartextDictionaryButton
            // 
            this.changeCleartextDictionaryButton.Image = global::NetworkMiner.Properties.Resources.openHS;
            resources.ApplyResources(this.changeCleartextDictionaryButton, "changeCleartextDictionaryButton");
            this.changeCleartextDictionaryButton.Name = "changeCleartextDictionaryButton";
            this.changeCleartextDictionaryButton.UseVisualStyleBackColor = true;
            this.changeCleartextDictionaryButton.Click += new System.EventHandler(this.changeCleartextDictionaryButton_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cleartextSearchModeComboBox
            // 
            resources.ApplyResources(this.cleartextSearchModeComboBox, "cleartextSearchModeComboBox");
            this.cleartextSearchModeComboBox.FormattingEnabled = true;
            this.cleartextSearchModeComboBox.Items.AddRange(new object[] {
            resources.GetString("cleartextSearchModeComboBox.Items"),
            resources.GetString("cleartextSearchModeComboBox.Items1"),
            resources.GetString("cleartextSearchModeComboBox.Items2"),
            resources.GetString("cleartextSearchModeComboBox.Items3")});
            this.cleartextSearchModeComboBox.Name = "cleartextSearchModeComboBox";
            this.cleartextSearchModeComboBox.SelectedIndexChanged += new System.EventHandler(this.cleartextSearchModeComboBox_SelectedIndexChanged);
            // 
            // dictionaryNameLabel
            // 
            resources.ApplyResources(this.dictionaryNameLabel, "dictionaryNameLabel");
            this.dictionaryNameLabel.Name = "dictionaryNameLabel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPageReceivedFrames
            // 
            this.tabPageReceivedFrames.Controls.Add(this.framesTreeView);
            this.tabPageReceivedFrames.Controls.Add(this.ReceivedFramesClearButton);
            resources.ApplyResources(this.tabPageReceivedFrames, "tabPageReceivedFrames");
            this.tabPageReceivedFrames.Name = "tabPageReceivedFrames";
            this.tabPageReceivedFrames.UseVisualStyleBackColor = true;
            // 
            // framesTreeView
            // 
            resources.ApplyResources(this.framesTreeView, "framesTreeView");
            this.framesTreeView.Name = "framesTreeView";
            // 
            // ReceivedFramesClearButton
            // 
            resources.ApplyResources(this.ReceivedFramesClearButton, "ReceivedFramesClearButton");
            this.ReceivedFramesClearButton.Name = "ReceivedFramesClearButton";
            this.ReceivedFramesClearButton.UseVisualStyleBackColor = true;
            this.ReceivedFramesClearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageAnomalyLog
            // 
            this.tabPageAnomalyLog.Controls.Add(this.anomalyLog);
            this.tabPageAnomalyLog.Controls.Add(this.clearAnomaliesButton);
            resources.ApplyResources(this.tabPageAnomalyLog, "tabPageAnomalyLog");
            this.tabPageAnomalyLog.Name = "tabPageAnomalyLog";
            this.tabPageAnomalyLog.UseVisualStyleBackColor = true;
            // 
            // anomalyLog
            // 
            this.anomalyLog.AcceptsReturn = true;
            this.anomalyLog.AcceptsTab = true;
            resources.ApplyResources(this.anomalyLog, "anomalyLog");
            this.anomalyLog.Name = "anomalyLog";
            this.anomalyLog.ReadOnly = true;
            // 
            // clearAnomaliesButton
            // 
            resources.ApplyResources(this.clearAnomaliesButton, "clearAnomaliesButton");
            this.clearAnomaliesButton.Name = "clearAnomaliesButton";
            this.clearAnomaliesButton.UseVisualStyleBackColor = true;
            this.clearAnomaliesButton.Click += new System.EventHandler(this.clearAnomaliesButton_Click);
            // 
            // casePanelBox
            // 
            this.casePanelBox.Controls.Add(this.casePanelFileListView);
            this.casePanelBox.Controls.Add(this.reloadCaseFilesButton);
            resources.ApplyResources(this.casePanelBox, "casePanelBox");
            this.casePanelBox.Name = "casePanelBox";
            this.casePanelBox.TabStop = false;
            // 
            // casePanelFileListView
            // 
            this.casePanelFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.caseFilenameColumn,
            this.caseMd5Column});
            this.casePanelFileListView.ContextMenuStrip = this.caseFileContextMenuStrip;
            resources.ApplyResources(this.casePanelFileListView, "casePanelFileListView");
            this.casePanelFileListView.FullRowSelect = true;
            this.casePanelFileListView.Name = "casePanelFileListView";
            this.casePanelFileListView.ShowItemToolTips = true;
            this.casePanelFileListView.UseCompatibleStateImageBehavior = false;
            this.casePanelFileListView.View = System.Windows.Forms.View.Details;
            this.casePanelFileListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.casePanelFileListView_MouseDown);
            // 
            // caseFilenameColumn
            // 
            resources.ApplyResources(this.caseFilenameColumn, "caseFilenameColumn");
            // 
            // caseMd5Column
            // 
            resources.ApplyResources(this.caseMd5Column, "caseMd5Column");
            // 
            // caseFileContextMenuStrip
            // 
            this.caseFileContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.caseFileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMetadataToolStripMenuItem,
            this.openParentFolderToolStripMenuItem,
            this.removeCaseFileMenuItem,
            this.removeSelectedFilesAndReloadCaseFilesToolStripMenuItem});
            this.caseFileContextMenuStrip.Name = "caseFileContextMenuStrip";
            resources.ApplyResources(this.caseFileContextMenuStrip, "caseFileContextMenuStrip");
            // 
            // showMetadataToolStripMenuItem
            // 
            this.showMetadataToolStripMenuItem.Name = "showMetadataToolStripMenuItem";
            resources.ApplyResources(this.showMetadataToolStripMenuItem, "showMetadataToolStripMenuItem");
            this.showMetadataToolStripMenuItem.Click += new System.EventHandler(this.showMetadataToolStripMenuItem_Click);
            // 
            // openParentFolderToolStripMenuItem
            // 
            this.openParentFolderToolStripMenuItem.Name = "openParentFolderToolStripMenuItem";
            resources.ApplyResources(this.openParentFolderToolStripMenuItem, "openParentFolderToolStripMenuItem");
            this.openParentFolderToolStripMenuItem.Click += new System.EventHandler(this.openParentFolderToolStripMenuItem_Click);
            // 
            // removeCaseFileMenuItem
            // 
            this.removeCaseFileMenuItem.Name = "removeCaseFileMenuItem";
            resources.ApplyResources(this.removeCaseFileMenuItem, "removeCaseFileMenuItem");
            this.removeCaseFileMenuItem.Click += new System.EventHandler(this.removeCaseFileMenuItem_Click);
            // 
            // removeSelectedFilesAndReloadCaseFilesToolStripMenuItem
            // 
            this.removeSelectedFilesAndReloadCaseFilesToolStripMenuItem.Name = "removeSelectedFilesAndReloadCaseFilesToolStripMenuItem";
            resources.ApplyResources(this.removeSelectedFilesAndReloadCaseFilesToolStripMenuItem, "removeSelectedFilesAndReloadCaseFilesToolStripMenuItem");
            this.removeSelectedFilesAndReloadCaseFilesToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedFilesAndReloadCaseFilesToolStripMenuItem_Click);
            // 
            // reloadCaseFilesButton
            // 
            resources.ApplyResources(this.reloadCaseFilesButton, "reloadCaseFilesButton");
            this.reloadCaseFilesButton.Name = "reloadCaseFilesButton";
            this.reloadCaseFilesButton.UseVisualStyleBackColor = true;
            this.reloadCaseFilesButton.Click += new System.EventHandler(this.reloadCaseFilesButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.snifferBufferToolStripProgressBar});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // snifferBufferToolStripProgressBar
            // 
            this.snifferBufferToolStripProgressBar.ForeColor = System.Drawing.Color.Purple;
            this.snifferBufferToolStripProgressBar.Name = "snifferBufferToolStripProgressBar";
            resources.ApplyResources(this.snifferBufferToolStripProgressBar, "snifferBufferToolStripProgressBar");
            this.snifferBufferToolStripProgressBar.Step = 1;
            this.snifferBufferToolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.readFromPacketCacheToolStripMenuItem,
            this.receivePcapOverIPToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.printReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::NetworkMiner.Properties.Resources.openHS;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // readFromPacketCacheToolStripMenuItem
            // 
            this.readFromPacketCacheToolStripMenuItem.Image = global::NetworkMiner.Properties.Resources.PacketCache_16x16;
            this.readFromPacketCacheToolStripMenuItem.Name = "readFromPacketCacheToolStripMenuItem";
            resources.ApplyResources(this.readFromPacketCacheToolStripMenuItem, "readFromPacketCacheToolStripMenuItem");
            this.readFromPacketCacheToolStripMenuItem.Click += new System.EventHandler(this.readFromPacketCacheToolStripMenuItem_Click);
            // 
            // receivePcapOverIPToolStripMenuItem
            // 
            this.receivePcapOverIPToolStripMenuItem.Name = "receivePcapOverIPToolStripMenuItem";
            resources.ApplyResources(this.receivePcapOverIPToolStripMenuItem, "receivePcapOverIPToolStripMenuItem");
            this.receivePcapOverIPToolStripMenuItem.Click += new System.EventHandler(this.receivePcapOverIPToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.credentialsToolStripMenuItem,
            this.dnsRecordsToolStripMenuItem,
            this.fileInfosToolStripMenuItem,
            this.hostsToolStripMenuItem,
            this.messagesToolStripMenuItem,
            this.parametersToolStripMenuItem,
            this.sessionsToolStripMenuItem});
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            // 
            // credentialsToolStripMenuItem
            // 
            this.credentialsToolStripMenuItem.Name = "credentialsToolStripMenuItem";
            resources.ApplyResources(this.credentialsToolStripMenuItem, "credentialsToolStripMenuItem");
            this.credentialsToolStripMenuItem.Click += new System.EventHandler(this.credentialsToolStripMenuItem_Click);
            // 
            // dnsRecordsToolStripMenuItem
            // 
            this.dnsRecordsToolStripMenuItem.Name = "dnsRecordsToolStripMenuItem";
            resources.ApplyResources(this.dnsRecordsToolStripMenuItem, "dnsRecordsToolStripMenuItem");
            this.dnsRecordsToolStripMenuItem.Click += new System.EventHandler(this.dnsRecordsToolStripMenuItem_Click);
            // 
            // fileInfosToolStripMenuItem
            // 
            this.fileInfosToolStripMenuItem.Name = "fileInfosToolStripMenuItem";
            resources.ApplyResources(this.fileInfosToolStripMenuItem, "fileInfosToolStripMenuItem");
            this.fileInfosToolStripMenuItem.Click += new System.EventHandler(this.fileInfosToolStripMenuItem_Click);
            // 
            // hostsToolStripMenuItem
            // 
            this.hostsToolStripMenuItem.Name = "hostsToolStripMenuItem";
            resources.ApplyResources(this.hostsToolStripMenuItem, "hostsToolStripMenuItem");
            this.hostsToolStripMenuItem.Click += new System.EventHandler(this.hostsToolStripMenuItem_Click);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            resources.ApplyResources(this.messagesToolStripMenuItem, "messagesToolStripMenuItem");
            this.messagesToolStripMenuItem.Click += new System.EventHandler(this.messagesToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            resources.ApplyResources(this.parametersToolStripMenuItem, "parametersToolStripMenuItem");
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            resources.ApplyResources(this.sessionsToolStripMenuItem, "sessionsToolStripMenuItem");
            this.sessionsToolStripMenuItem.Click += new System.EventHandler(this.sessionsToolStripMenuItem_Click);
            // 
            // printReportToolStripMenuItem
            // 
            this.printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            resources.ApplyResources(this.printReportToolStripMenuItem, "printReportToolStripMenuItem");
            this.printReportToolStripMenuItem.Click += new System.EventHandler(this.printReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.downloadRIPEDBToolStripMenuItem,
            this.toolStripSeparator2,
            this.startCapturingToolStripMenuItem,
            this.stopCapturingToolStripMenuItem,
            this.toolStripSeparator3,
            this.clearGUIToolStripMenuItem,
            this.resetCapturedDataToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // downloadRIPEDBToolStripMenuItem
            // 
            resources.ApplyResources(this.downloadRIPEDBToolStripMenuItem, "downloadRIPEDBToolStripMenuItem");
            this.downloadRIPEDBToolStripMenuItem.Name = "downloadRIPEDBToolStripMenuItem";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // startCapturingToolStripMenuItem
            // 
            resources.ApplyResources(this.startCapturingToolStripMenuItem, "startCapturingToolStripMenuItem");
            this.startCapturingToolStripMenuItem.Image = global::NetworkMiner.Properties.Resources.PlayHS;
            this.startCapturingToolStripMenuItem.Name = "startCapturingToolStripMenuItem";
            this.startCapturingToolStripMenuItem.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopCapturingToolStripMenuItem
            // 
            this.stopCapturingToolStripMenuItem.Image = global::NetworkMiner.Properties.Resources.StopHS;
            this.stopCapturingToolStripMenuItem.Name = "stopCapturingToolStripMenuItem";
            resources.ApplyResources(this.stopCapturingToolStripMenuItem, "stopCapturingToolStripMenuItem");
            this.stopCapturingToolStripMenuItem.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // clearGUIToolStripMenuItem
            // 
            resources.ApplyResources(this.clearGUIToolStripMenuItem, "clearGUIToolStripMenuItem");
            this.clearGUIToolStripMenuItem.Name = "clearGUIToolStripMenuItem";
            this.clearGUIToolStripMenuItem.Click += new System.EventHandler(this.clearGUIToolStripMenuItem_Click);
            // 
            // resetCapturedDataToolStripMenuItem
            // 
            this.resetCapturedDataToolStripMenuItem.Image = global::NetworkMiner.Properties.Resources.DeleteFolderHS;
            this.resetCapturedDataToolStripMenuItem.Name = "resetCapturedDataToolStripMenuItem";
            resources.ApplyResources(this.resetCapturedDataToolStripMenuItem, "resetCapturedDataToolStripMenuItem");
            this.resetCapturedDataToolStripMenuItem.Click += new System.EventHandler(this.resetCapturedDataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getUpgradeCodeToolStripMenuItem,
            this.signWithLicenseToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutNetworkMinerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // getUpgradeCodeToolStripMenuItem
            // 
            resources.ApplyResources(this.getUpgradeCodeToolStripMenuItem, "getUpgradeCodeToolStripMenuItem");
            this.getUpgradeCodeToolStripMenuItem.Name = "getUpgradeCodeToolStripMenuItem";
            this.getUpgradeCodeToolStripMenuItem.Click += new System.EventHandler(this.getUpgradeCodeToolStripMenuItem_Click);
            // 
            // signWithLicenseToolStripMenuItem
            // 
            resources.ApplyResources(this.signWithLicenseToolStripMenuItem, "signWithLicenseToolStripMenuItem");
            this.signWithLicenseToolStripMenuItem.Name = "signWithLicenseToolStripMenuItem";
            this.signWithLicenseToolStripMenuItem.Click += new System.EventHandler(this.signWithLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // aboutNetworkMinerToolStripMenuItem
            // 
            this.aboutNetworkMinerToolStripMenuItem.Name = "aboutNetworkMinerToolStripMenuItem";
            resources.ApplyResources(this.aboutNetworkMinerToolStripMenuItem, "aboutNetworkMinerToolStripMenuItem");
            this.aboutNetworkMinerToolStripMenuItem.Click += new System.EventHandler(this.aboutNetworkMinerToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vietnameseToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // vietnameseToolStripMenuItem
            // 
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            resources.ApplyResources(this.vietnameseToolStripMenuItem, "vietnameseToolStripMenuItem");
            this.vietnameseToolStripMenuItem.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // networkAdaptersComboBox
            // 
            resources.ApplyResources(this.networkAdaptersComboBox, "networkAdaptersComboBox");
            this.networkAdaptersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.networkAdaptersComboBox.FormattingEnabled = true;
            this.networkAdaptersComboBox.Name = "networkAdaptersComboBox";
            this.networkAdaptersComboBox.SelectedIndexChanged += new System.EventHandler(this.networkAdaptersComboBox_SelectedIndexChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // openPcapFileDialog
            // 
            this.openPcapFileDialog.FileName = "openPcapFileDialog";
            this.openPcapFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // exportDataToFileDialog
            // 
            this.exportDataToFileDialog.FileName = "export.json";
            resources.ApplyResources(this.exportDataToFileDialog, "exportDataToFileDialog");
            // 
            // openTextFileDialog
            // 
            this.openTextFileDialog.DefaultExt = "*.txt";
            this.openTextFileDialog.FileName = "*.txt";
            resources.ApplyResources(this.openTextFileDialog, "openTextFileDialog");
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Image = global::NetworkMiner.Properties.Resources.Filter2HS;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Image = global::NetworkMiner.Properties.Resources.StopHS;
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Image = global::NetworkMiner.Properties.Resources.PlayHS;
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // NetworkMinerForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.networkAdaptersComboBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.startButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NetworkMinerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkMinerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NetworkMinerForm_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.NetworkMinerForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.NetworkMinerForm_DragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageDetectedHosts.ResumeLayout(false);
            this.hostMenuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageBrowsers.ResumeLayout(false);
            this.browsersSplitContainer.Panel1.ResumeLayout(false);
            this.browsersSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browsersSplitContainer)).EndInit();
            this.browsersSplitContainer.ResumeLayout(false);
            this.browsersMenuStrip.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageFiles.ResumeLayout(false);
            this.tabPageImages.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            this.messagesSplitContainer.Panel1.ResumeLayout(false);
            this.messagesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.messagesSplitContainer)).EndInit();
            this.messagesSplitContainer.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPageCredentials.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageVoIP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voipDataGridView)).EndInit();
            this.tabPageSessions.ResumeLayout(false);
            this.tabPageDns.ResumeLayout(false);
            this.tabPageParameters.ResumeLayout(false);
            this.parametersContextMenuStrip.ResumeLayout(false);
            this.tabPageKeywords.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPageCleartext.ResumeLayout(false);
            this.tabPageCleartext.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageReceivedFrames.ResumeLayout(false);
            this.tabPageAnomalyLog.ResumeLayout(false);
            this.tabPageAnomalyLog.PerformLayout();
            this.casePanelBox.ResumeLayout(false);
            this.caseFileContextMenuStrip.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAnomalyLog;
        private System.Windows.Forms.TabPage tabPageReceivedFrames;
        private System.Windows.Forms.TreeView framesTreeView;
        private System.Windows.Forms.ComboBox networkAdaptersComboBox;
        private System.Windows.Forms.TreeView networkHostTreeView;
        private System.Windows.Forms.TabPage tabPageCleartext;
        private System.Windows.Forms.TextBox cleartextTextBox;
        //private CleartextTextBox cleartextTextBox;
        private System.Windows.Forms.Button ReceivedFramesClearButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutNetworkMinerToolStripMenuItem;
        //private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dictionaryNameLabel;
        private System.Windows.Forms.Button detectedHostsTreeRebuildButton;
        private System.Windows.Forms.TextBox anomalyLog;
        private System.Windows.Forms.Button clearAnomaliesButton;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPcapFileDialog;
        private System.Windows.Forms.ToolStripMenuItem resetCapturedDataToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageFiles;
        private System.Windows.Forms.TabPage tabPageImages;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.ColumnHeader filenameHeader;
        private System.Windows.Forms.ColumnHeader detailsHeader;
        private System.Windows.Forms.ColumnHeader sourceHostHeader;
        private System.Windows.Forms.ColumnHeader sourcePortHeader;
        private System.Windows.Forms.ColumnHeader destinationHostHeader;
        private System.Windows.Forms.ColumnHeader destinationPortHeader;
        private System.Windows.Forms.ColumnHeader fileSizeHeader;
        private System.Windows.Forms.ColumnHeader reconstructedFilePathHeader;
        private System.Windows.Forms.ListView imagesListView;
        private System.Windows.Forms.ColumnHeader protocolHeader;
        private System.Windows.Forms.TabPage tabPageCredentials;
        private System.Windows.Forms.ListView credentialsListView;
        private System.Windows.Forms.ColumnHeader serverHostHeader;
        private System.Windows.Forms.ColumnHeader protocolStringHeader;
        private System.Windows.Forms.ColumnHeader usernameHeader;
        private System.Windows.Forms.ColumnHeader passwordHeader;
        private System.Windows.Forms.ColumnHeader validHeader;
        private System.Windows.Forms.TabPage tabPageKeywords;
        private System.Windows.Forms.ListView detectedKeywordsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderFrameNr;
        private System.Windows.Forms.ColumnHeader columnHeaderKeyword;
        private System.Windows.Forms.ColumnHeader columnHeaderContext;
        private System.Windows.Forms.Button addKeywordButton;
        private System.Windows.Forms.Button removeKeywordButton;
        private System.Windows.Forms.ColumnHeader columnHeaderTimestamp;
        private System.Windows.Forms.ColumnHeader columnHeaderSourceHost;
        private System.Windows.Forms.ColumnHeader columnHeaderSourcePort;
        private System.Windows.Forms.ColumnHeader columnDestinationHost;
        private System.Windows.Forms.ColumnHeader columnHeaderDestinationPort;
        private System.Windows.Forms.ListBox keywordListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.ComboBox cleartextSearchModeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageParameters;
        private System.Windows.Forms.ListView parametersListView;
        private System.Windows.Forms.ColumnHeader parameterSourceHost;
        private System.Windows.Forms.ColumnHeader parameterDestinationHost;
        private System.Windows.Forms.ColumnHeader parameterSourcePort;
        private System.Windows.Forms.ColumnHeader parameterDestinationPort;
        private System.Windows.Forms.ColumnHeader parameterName;
        private System.Windows.Forms.ColumnHeader parameterValue;
        private System.Windows.Forms.ColumnHeader parameterTimestamp;
        private System.Windows.Forms.ColumnHeader parameterDetails;
        private System.Windows.Forms.ColumnHeader parameterFrameNumber;
        private System.Windows.Forms.ColumnHeader loggedInClientHeader;
        private System.Windows.Forms.ColumnHeader loginTimestamp;
        private System.Windows.Forms.ToolStripMenuItem startCapturingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCapturingToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPageDns;
        private System.Windows.Forms.ListView dnsListView;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsFrameNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsTimestamp;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsClient;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsServer;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsQuery;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsAnswer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar snifferBufferToolStripProgressBar;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsIpTtl;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsRecordType;
        private System.Windows.Forms.ComboBox hostSortOrderComboBox;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsTransactionId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hostSortingLabel;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsDnsTtl;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsClientPort;
        private System.Windows.Forms.ColumnHeader columnHeaderDnsServerPort;
        private System.Windows.Forms.GroupBox casePanelBox;
        private System.Windows.Forms.ListView casePanelFileListView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button reloadCaseFilesButton;
        private System.Windows.Forms.ContextMenuStrip caseFileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeCaseFileMenuItem;
        private System.Windows.Forms.ColumnHeader reconstructedFileInitialFrameNumber;
        private System.Windows.Forms.ColumnHeader reconstructedFileTimestampColumnHeader;
        private System.Windows.Forms.ColumnHeader caseFilenameColumn;
        private System.Windows.Forms.ColumnHeader caseMd5Column;
        private System.Windows.Forms.ToolStripMenuItem openParentFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printReportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip hostMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectHostColorMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem removeHostColorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip parametersContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyParameterNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyParameterValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTextToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageSessions;
        private System.Windows.Forms.ListView sessionsListView;
        private System.Windows.Forms.ColumnHeader sessionFrameNrColumnHeader;
        private System.Windows.Forms.ColumnHeader sessionClientHostColumnHeader;
        private System.Windows.Forms.ColumnHeader sessionClientPortColumnHeader;
        private System.Windows.Forms.ColumnHeader sessionServerHostColumnHeader;
        private System.Windows.Forms.ColumnHeader sessionServerPortColumnHeader;
        private System.Windows.Forms.ColumnHeader sessionProtocolColumnHeader;
        private System.Windows.Forms.ColumnHeader sessionStartTimeColumnHeader;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.SplitContainer messagesSplitContainer;
        private System.Windows.Forms.ListView messagesListView;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ColumnHeader messageFrameColumnHeader;
        private System.Windows.Forms.ColumnHeader messageSourceHostColumnHeader;
        private System.Windows.Forms.ColumnHeader messageDestinationHostColumnHeader;
        private System.Windows.Forms.ColumnHeader messageFromColumnHeader;
        private System.Windows.Forms.ColumnHeader messageToColumnHeader;
        private System.Windows.Forms.ColumnHeader messageSubjectColumnHeader;
        private System.Windows.Forms.ColumnHeader messageProtocolColumnHeader;
        private System.Windows.Forms.ColumnHeader messageTimestampColumnHeader;
        private System.Windows.Forms.ListView messageAttributeListView;
        private System.Windows.Forms.ColumnHeader attributeNameColumnHeader;
        private System.Windows.Forms.ColumnHeader attributeValueColumnHeader;
        private System.Windows.Forms.ColumnHeader extensionHeader;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnsRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportDataToFileDialog;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivePcapOverIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getUpgradeCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signWithLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button changeCleartextDictionaryButton;
        private System.Windows.Forms.OpenFileDialog openTextFileDialog;
        private System.Windows.Forms.ToolStripMenuItem downloadRIPEDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckBox showCookiesCheckBox;
        private System.Windows.Forms.CheckBox showNtlmSspCheckBox;
        private System.Windows.Forms.CheckBox maskPasswordsCheckBox;
        private System.Windows.Forms.ToolStripMenuItem clearGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ColumnHeader columnHeaderAlexaTop1M;
        private System.Windows.Forms.Button addKeywordsFromFileButton;
        private System.Windows.Forms.ToolStripMenuItem showMetadataToolStripMenuItem;
        private System.Windows.Forms.ComboBox messageEncodingComboBox;
        private KeywordFilterControlForListViewItems parametersKeywordFilterControl;
        private KeywordFilterControlForListViewItems filesKeywordFilterControl;
        private KeywordFilterControlForListViewItems dnsKeywordFilterControl;
        private System.Windows.Forms.TabPage tabPageBrowsers;
        private System.Windows.Forms.TreeView httpTransactionTreeView;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedFilesAndReloadCaseFilesToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TabPage tabPageDetectedHosts;
        private KeywordFilterControlForListViewItems messagesKeywordFilterControl;
        private System.Windows.Forms.ListView messageAttachmentListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private KeywordFilterControlForListViewItems sessionsKeywordFilterControl;
        private System.Windows.Forms.ToolStripMenuItem readFromPacketCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip browsersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem1;
        private System.Windows.Forms.PropertyGrid httpTransactionPropertyGrid;
        private System.Windows.Forms.SplitContainer browsersSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem setAdvertismentColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox findHttpTransactionTextBox;
        private System.Windows.Forms.Button findHttpTransactionButton;
        private System.Windows.Forms.CheckBox findHttpTransactionCaseSensitiveCheckBox;
        private System.Windows.Forms.Label findHttpTransactionLabel;
        private System.Windows.Forms.ToolStripMenuItem setInternetTrackerColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectParentNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllButThisToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabPage tabPageVoIP;
        private System.Windows.Forms.DataGridView voipDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn VoipPlayColumn;
        private System.Windows.Forms.DataGridViewImageColumn VoipStopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoipFromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoipToColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoipStartColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoipDurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoipEncodingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoipCallIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoipSourceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoipDestinationColumn;
        private System.Windows.Forms.DataGridViewButtonColumn VoipSaveWavColumn;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

