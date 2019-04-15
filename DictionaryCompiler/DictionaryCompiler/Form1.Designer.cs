namespace DictionaryCompiler
{
    partial class Form1
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.langBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.langTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.openKeyConfigBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.openWordsFileBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.compileBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.meaningCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.pronCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.sloWordsCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.engWordsCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.urlCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.orderCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.countCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.keysBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.browseSrcPathBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.apiKeyTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.inputTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.overwriteCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.outputNameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.xlsxCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.exportBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.txtCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.browseOutPathBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.outputTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-1, 93);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(726, 340);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.langBtn);
            this.tabPage1.Controls.Add(this.materialLabel9);
            this.tabPage1.Controls.Add(this.langTextBox);
            this.tabPage1.Controls.Add(this.openKeyConfigBtn);
            this.tabPage1.Controls.Add(this.openWordsFileBtn);
            this.tabPage1.Controls.Add(this.materialLabel8);
            this.tabPage1.Controls.Add(this.compileBtn);
            this.tabPage1.Controls.Add(this.meaningCheck);
            this.tabPage1.Controls.Add(this.pronCheck);
            this.tabPage1.Controls.Add(this.sloWordsCheck);
            this.tabPage1.Controls.Add(this.engWordsCheck);
            this.tabPage1.Controls.Add(this.urlCheck);
            this.tabPage1.Controls.Add(this.orderCheck);
            this.tabPage1.Controls.Add(this.countCheck);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.keysBtn);
            this.tabPage1.Controls.Add(this.browseSrcPathBtn);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.apiKeyTextBox);
            this.tabPage1.Controls.Add(this.inputTextBox);
            this.tabPage1.Controls.Add(this.materialDivider1);
            this.tabPage1.Controls.Add(this.materialDivider2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(552, 278);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 36);
            this.materialRaisedButton1.TabIndex = 38;
            this.materialRaisedButton1.Text = "Open in browser";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // langBtn
            // 
            this.langBtn.Depth = 0;
            this.langBtn.Location = new System.Drawing.Point(633, 89);
            this.langBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.langBtn.Name = "langBtn";
            this.langBtn.Primary = true;
            this.langBtn.Size = new System.Drawing.Size(75, 23);
            this.langBtn.TabIndex = 33;
            this.langBtn.Text = "Lang lib";
            this.langBtn.UseVisualStyleBackColor = true;
            this.langBtn.Click += new System.EventHandler(this.langBtn_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(1, 93);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(89, 19);
            this.materialLabel9.TabIndex = 32;
            this.materialLabel9.Text = "Output lang:";
            // 
            // langTextBox
            // 
            this.langTextBox.Depth = 0;
            this.langTextBox.Hint = "Select the output language ";
            this.langTextBox.Location = new System.Drawing.Point(103, 89);
            this.langTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.langTextBox.Name = "langTextBox";
            this.langTextBox.PasswordChar = '\0';
            this.langTextBox.SelectedText = "";
            this.langTextBox.SelectionLength = 0;
            this.langTextBox.SelectionStart = 0;
            this.langTextBox.Size = new System.Drawing.Size(524, 23);
            this.langTextBox.TabIndex = 31;
            this.langTextBox.Text = "Slovenian";
            this.langTextBox.UseSystemPasswordChar = false;
            // 
            // openKeyConfigBtn
            // 
            this.openKeyConfigBtn.AutoSize = true;
            this.openKeyConfigBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openKeyConfigBtn.Depth = 0;
            this.openKeyConfigBtn.Location = new System.Drawing.Point(376, 254);
            this.openKeyConfigBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openKeyConfigBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openKeyConfigBtn.Name = "openKeyConfigBtn";
            this.openKeyConfigBtn.Primary = false;
            this.openKeyConfigBtn.Size = new System.Drawing.Size(114, 36);
            this.openKeyConfigBtn.TabIndex = 30;
            this.openKeyConfigBtn.Text = "Open keys file";
            this.openKeyConfigBtn.UseVisualStyleBackColor = true;
            this.openKeyConfigBtn.Click += new System.EventHandler(this.openConfigBtn_Click);
            // 
            // openWordsFileBtn
            // 
            this.openWordsFileBtn.AutoSize = true;
            this.openWordsFileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openWordsFileBtn.Depth = 0;
            this.openWordsFileBtn.Location = new System.Drawing.Point(376, 218);
            this.openWordsFileBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openWordsFileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openWordsFileBtn.Name = "openWordsFileBtn";
            this.openWordsFileBtn.Primary = false;
            this.openWordsFileBtn.Size = new System.Drawing.Size(129, 36);
            this.openWordsFileBtn.TabIndex = 29;
            this.openWordsFileBtn.Text = "Open words file";
            this.openWordsFileBtn.UseVisualStyleBackColor = true;
            this.openWordsFileBtn.Click += new System.EventHandler(this.openWordsFileBtn_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(372, 190);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(42, 19);
            this.materialLabel8.TabIndex = 28;
            this.materialLabel8.Text = "Misc";
            // 
            // compileBtn
            // 
            this.compileBtn.Depth = 0;
            this.compileBtn.Location = new System.Drawing.Point(633, 278);
            this.compileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.compileBtn.Name = "compileBtn";
            this.compileBtn.Primary = true;
            this.compileBtn.Size = new System.Drawing.Size(75, 36);
            this.compileBtn.TabIndex = 27;
            this.compileBtn.Text = "compile";
            this.compileBtn.UseVisualStyleBackColor = true;
            this.compileBtn.Click += new System.EventHandler(this.compileBtn_Click);
            // 
            // meaningCheck
            // 
            this.meaningCheck.AutoSize = true;
            this.meaningCheck.Depth = 0;
            this.meaningCheck.Enabled = false;
            this.meaningCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.meaningCheck.Location = new System.Drawing.Point(180, 254);
            this.meaningCheck.Margin = new System.Windows.Forms.Padding(0);
            this.meaningCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.meaningCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.meaningCheck.Name = "meaningCheck";
            this.meaningCheck.Ripple = true;
            this.meaningCheck.Size = new System.Drawing.Size(83, 30);
            this.meaningCheck.TabIndex = 26;
            this.meaningCheck.Text = "Meaning";
            this.meaningCheck.UseVisualStyleBackColor = true;
            // 
            // pronCheck
            // 
            this.pronCheck.AutoSize = true;
            this.pronCheck.Depth = 0;
            this.pronCheck.Enabled = false;
            this.pronCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.pronCheck.Location = new System.Drawing.Point(180, 284);
            this.pronCheck.Margin = new System.Windows.Forms.Padding(0);
            this.pronCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pronCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.pronCheck.Name = "pronCheck";
            this.pronCheck.Ripple = true;
            this.pronCheck.Size = new System.Drawing.Size(116, 30);
            this.pronCheck.TabIndex = 25;
            this.pronCheck.Text = "Pronunciation";
            this.pronCheck.UseVisualStyleBackColor = true;
            // 
            // sloWordsCheck
            // 
            this.sloWordsCheck.AutoSize = true;
            this.sloWordsCheck.Checked = true;
            this.sloWordsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sloWordsCheck.Depth = 0;
            this.sloWordsCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.sloWordsCheck.Location = new System.Drawing.Point(33, 284);
            this.sloWordsCheck.Margin = new System.Windows.Forms.Padding(0);
            this.sloWordsCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sloWordsCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.sloWordsCheck.Name = "sloWordsCheck";
            this.sloWordsCheck.Ripple = true;
            this.sloWordsCheck.Size = new System.Drawing.Size(146, 30);
            this.sloWordsCheck.TabIndex = 24;
            this.sloWordsCheck.Text = "TranslatedwWords";
            this.sloWordsCheck.UseVisualStyleBackColor = true;
            // 
            // engWordsCheck
            // 
            this.engWordsCheck.AutoSize = true;
            this.engWordsCheck.Checked = true;
            this.engWordsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.engWordsCheck.Depth = 0;
            this.engWordsCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.engWordsCheck.Location = new System.Drawing.Point(34, 254);
            this.engWordsCheck.Margin = new System.Windows.Forms.Padding(0);
            this.engWordsCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.engWordsCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.engWordsCheck.Name = "engWordsCheck";
            this.engWordsCheck.Ripple = true;
            this.engWordsCheck.Size = new System.Drawing.Size(119, 30);
            this.engWordsCheck.TabIndex = 23;
            this.engWordsCheck.Text = "Original words";
            this.engWordsCheck.UseVisualStyleBackColor = true;
            // 
            // urlCheck
            // 
            this.urlCheck.AutoSize = true;
            this.urlCheck.Checked = true;
            this.urlCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.urlCheck.Depth = 0;
            this.urlCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.urlCheck.Location = new System.Drawing.Point(190, 218);
            this.urlCheck.Margin = new System.Windows.Forms.Padding(0);
            this.urlCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.urlCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.urlCheck.Name = "urlCheck";
            this.urlCheck.Ripple = true;
            this.urlCheck.Size = new System.Drawing.Size(97, 30);
            this.urlCheck.TabIndex = 22;
            this.urlCheck.Text = "Image URL";
            this.urlCheck.UseVisualStyleBackColor = true;
            // 
            // orderCheck
            // 
            this.orderCheck.AutoSize = true;
            this.orderCheck.Checked = true;
            this.orderCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.orderCheck.Depth = 0;
            this.orderCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.orderCheck.Location = new System.Drawing.Point(91, 218);
            this.orderCheck.Margin = new System.Windows.Forms.Padding(0);
            this.orderCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.orderCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderCheck.Name = "orderCheck";
            this.orderCheck.Ripple = true;
            this.orderCheck.Size = new System.Drawing.Size(90, 30);
            this.orderCheck.TabIndex = 21;
            this.orderCheck.Text = "Order A-Z";
            this.orderCheck.UseVisualStyleBackColor = true;
            // 
            // countCheck
            // 
            this.countCheck.AutoSize = true;
            this.countCheck.Checked = true;
            this.countCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.countCheck.Depth = 0;
            this.countCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.countCheck.Location = new System.Drawing.Point(12, 218);
            this.countCheck.Margin = new System.Windows.Forms.Padding(0);
            this.countCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.countCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.countCheck.Name = "countCheck";
            this.countCheck.Ripple = true;
            this.countCheck.Size = new System.Drawing.Size(67, 30);
            this.countCheck.TabIndex = 20;
            this.countCheck.Text = "Count";
            this.countCheck.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 190);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(113, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "What to include";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 6);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Edit as required";
            // 
            // keysBtn
            // 
            this.keysBtn.Depth = 0;
            this.keysBtn.Location = new System.Drawing.Point(633, 60);
            this.keysBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.keysBtn.Name = "keysBtn";
            this.keysBtn.Primary = true;
            this.keysBtn.Size = new System.Drawing.Size(75, 23);
            this.keysBtn.TabIndex = 6;
            this.keysBtn.Text = "Keys";
            this.keysBtn.UseVisualStyleBackColor = true;
            this.keysBtn.Click += new System.EventHandler(this.keysBtn_Click);
            // 
            // browseSrcPathBtn
            // 
            this.browseSrcPathBtn.Depth = 0;
            this.browseSrcPathBtn.Location = new System.Drawing.Point(633, 31);
            this.browseSrcPathBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseSrcPathBtn.Name = "browseSrcPathBtn";
            this.browseSrcPathBtn.Primary = true;
            this.browseSrcPathBtn.Size = new System.Drawing.Size(75, 23);
            this.browseSrcPathBtn.TabIndex = 5;
            this.browseSrcPathBtn.Text = "Browse";
            this.browseSrcPathBtn.UseVisualStyleBackColor = true;
            this.browseSrcPathBtn.Click += new System.EventHandler(this.browseSrcPathBtn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(1, 64);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "API key:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(1, 35);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Source path:";
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Depth = 0;
            this.apiKeyTextBox.Hint = "Select or paste an api key";
            this.apiKeyTextBox.Location = new System.Drawing.Point(103, 60);
            this.apiKeyTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.PasswordChar = '\0';
            this.apiKeyTextBox.SelectedText = "";
            this.apiKeyTextBox.SelectionLength = 0;
            this.apiKeyTextBox.SelectionStart = 0;
            this.apiKeyTextBox.Size = new System.Drawing.Size(524, 23);
            this.apiKeyTextBox.TabIndex = 2;
            this.apiKeyTextBox.UseSystemPasswordChar = false;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Depth = 0;
            this.inputTextBox.Hint = "";
            this.inputTextBox.Location = new System.Drawing.Point(103, 31);
            this.inputTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.SelectedText = "";
            this.inputTextBox.SelectionLength = 0;
            this.inputTextBox.SelectionStart = 0;
            this.inputTextBox.Size = new System.Drawing.Size(524, 23);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "materialSingleLineTextField1";
            this.inputTextBox.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 184);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(718, 25);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 0);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(718, 25);
            this.materialDivider2.TabIndex = 19;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.progressBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compiling";
            this.tabPage2.UseWaitCursor = true;
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.InnerColor = System.Drawing.Color.White;
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(270, 128);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.Gray;
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar.ProgressWidth = 25;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.Size = new System.Drawing.Size(180, 180);
            this.progressBar.StartAngle = 270;
            this.progressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar.SubscriptText = "";
            this.progressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "/60";
            this.progressBar.TabIndex = 0;
            this.progressBar.Text = "26";
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.progressBar.UseWaitCursor = true;
            this.progressBar.Value = 68;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(718, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.overwriteCheck);
            this.tabPage4.Controls.Add(this.materialLabel10);
            this.tabPage4.Controls.Add(this.outputNameTextBox);
            this.tabPage4.Controls.Add(this.xlsxCheck);
            this.tabPage4.Controls.Add(this.exportBtn);
            this.tabPage4.Controls.Add(this.materialDivider6);
            this.tabPage4.Controls.Add(this.materialLabel7);
            this.tabPage4.Controls.Add(this.materialDivider5);
            this.tabPage4.Controls.Add(this.txtCheck);
            this.tabPage4.Controls.Add(this.browseOutPathBtn);
            this.tabPage4.Controls.Add(this.materialLabel6);
            this.tabPage4.Controls.Add(this.outputTextBox);
            this.tabPage4.Controls.Add(this.materialLabel5);
            this.tabPage4.Controls.Add(this.materialDivider4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(718, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Export";
            // 
            // overwriteCheck
            // 
            this.overwriteCheck.AutoSize = true;
            this.overwriteCheck.Checked = true;
            this.overwriteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwriteCheck.Depth = 0;
            this.overwriteCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.overwriteCheck.Location = new System.Drawing.Point(308, 105);
            this.overwriteCheck.Margin = new System.Windows.Forms.Padding(0);
            this.overwriteCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.overwriteCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.overwriteCheck.Name = "overwriteCheck";
            this.overwriteCheck.Ripple = true;
            this.overwriteCheck.Size = new System.Drawing.Size(89, 30);
            this.overwriteCheck.TabIndex = 51;
            this.overwriteCheck.Text = "Overwrite";
            this.overwriteCheck.UseVisualStyleBackColor = true;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(10, 116);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(122, 19);
            this.materialLabel10.TabIndex = 50;
            this.materialLabel10.Text = "Export file name:";
            // 
            // outputNameTextBox
            // 
            this.outputNameTextBox.Depth = 0;
            this.outputNameTextBox.Hint = "";
            this.outputNameTextBox.Location = new System.Drawing.Point(138, 112);
            this.outputNameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.outputNameTextBox.Name = "outputNameTextBox";
            this.outputNameTextBox.PasswordChar = '\0';
            this.outputNameTextBox.SelectedText = "";
            this.outputNameTextBox.SelectionLength = 0;
            this.outputNameTextBox.SelectionStart = 0;
            this.outputNameTextBox.Size = new System.Drawing.Size(146, 23);
            this.outputNameTextBox.TabIndex = 49;
            this.outputNameTextBox.Text = "Dictionary";
            this.outputNameTextBox.UseSystemPasswordChar = false;
            // 
            // xlsxCheck
            // 
            this.xlsxCheck.AutoSize = true;
            this.xlsxCheck.Depth = 0;
            this.xlsxCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.xlsxCheck.Location = new System.Drawing.Point(152, 281);
            this.xlsxCheck.Margin = new System.Windows.Forms.Padding(0);
            this.xlsxCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.xlsxCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.xlsxCheck.Name = "xlsxCheck";
            this.xlsxCheck.Ripple = true;
            this.xlsxCheck.Size = new System.Drawing.Size(123, 30);
            this.xlsxCheck.TabIndex = 47;
            this.xlsxCheck.Text = "Export as excel";
            this.xlsxCheck.UseVisualStyleBackColor = true;
            // 
            // exportBtn
            // 
            this.exportBtn.Depth = 0;
            this.exportBtn.Location = new System.Drawing.Point(614, 278);
            this.exportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Primary = true;
            this.exportBtn.Size = new System.Drawing.Size(96, 36);
            this.exportBtn.TabIndex = 46;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click_1);
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(-15, 247);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(748, 25);
            this.materialDivider6.TabIndex = 45;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(9, 75);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(110, 19);
            this.materialLabel7.TabIndex = 43;
            this.materialLabel7.Text = "Export settings";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(-3, 69);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(722, 25);
            this.materialDivider5.TabIndex = 44;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // txtCheck
            // 
            this.txtCheck.AutoSize = true;
            this.txtCheck.Checked = true;
            this.txtCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txtCheck.Depth = 0;
            this.txtCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtCheck.Location = new System.Drawing.Point(21, 281);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(0);
            this.txtCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.txtCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Ripple = true;
            this.txtCheck.Size = new System.Drawing.Size(107, 30);
            this.txtCheck.TabIndex = 42;
            this.txtCheck.Text = "Export as txt";
            this.txtCheck.UseVisualStyleBackColor = true;
            // 
            // browseOutPathBtn
            // 
            this.browseOutPathBtn.Depth = 0;
            this.browseOutPathBtn.Location = new System.Drawing.Point(638, 31);
            this.browseOutPathBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseOutPathBtn.Name = "browseOutPathBtn";
            this.browseOutPathBtn.Primary = true;
            this.browseOutPathBtn.Size = new System.Drawing.Size(75, 23);
            this.browseOutPathBtn.TabIndex = 41;
            this.browseOutPathBtn.Text = "Browse";
            this.browseOutPathBtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 35);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(94, 19);
            this.materialLabel6.TabIndex = 40;
            this.materialLabel6.Text = " Output path:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Depth = 0;
            this.outputTextBox.Hint = "";
            this.outputTextBox.Location = new System.Drawing.Point(108, 31);
            this.outputTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.PasswordChar = '\0';
            this.outputTextBox.SelectedText = "";
            this.outputTextBox.SelectionLength = 0;
            this.outputTextBox.SelectionStart = 0;
            this.outputTextBox.Size = new System.Drawing.Size(524, 23);
            this.outputTextBox.TabIndex = 39;
            this.outputTextBox.Text = "materialSingleLineTextField1";
            this.outputTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(10, 6);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(86, 19);
            this.materialLabel5.TabIndex = 37;
            this.materialLabel5.Text = "Output path";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(1, 0);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(718, 25);
            this.materialDivider4.TabIndex = 38;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 51);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(726, 36);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(-1, 407);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(726, 39);
            this.materialDivider3.TabIndex = 28;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(658, 51);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(57, 36);
            this.materialFlatButton1.TabIndex = 29;
            this.materialFlatButton1.Text = "About";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 445);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary Compiler";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField inputTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton keysBtn;
        private MaterialSkin.Controls.MaterialRaisedButton browseSrcPathBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private MaterialSkin.Controls.MaterialSingleLineTextField apiKeyTextBox;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialCheckBox meaningCheck;
        private MaterialSkin.Controls.MaterialCheckBox pronCheck;
        private MaterialSkin.Controls.MaterialCheckBox sloWordsCheck;
        private MaterialSkin.Controls.MaterialCheckBox engWordsCheck;
        private MaterialSkin.Controls.MaterialCheckBox urlCheck;
        private MaterialSkin.Controls.MaterialCheckBox orderCheck;
        private MaterialSkin.Controls.MaterialCheckBox countCheck;
        private MaterialSkin.Controls.MaterialRaisedButton compileBtn;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private CircularProgressBar.CircularProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialFlatButton openKeyConfigBtn;
        private MaterialSkin.Controls.MaterialFlatButton openWordsFileBtn;
        private MaterialSkin.Controls.MaterialRaisedButton langBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField langTextBox;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialCheckBox overwriteCheck;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        public MaterialSkin.Controls.MaterialSingleLineTextField outputNameTextBox;
        private MaterialSkin.Controls.MaterialCheckBox xlsxCheck;
        private MaterialSkin.Controls.MaterialRaisedButton exportBtn;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialCheckBox txtCheck;
        private MaterialSkin.Controls.MaterialRaisedButton browseOutPathBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField outputTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

