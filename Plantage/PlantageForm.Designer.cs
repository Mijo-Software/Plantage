namespace Plantage
{
  partial class PlantageForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantageForm));
      this.label1 = new System.Windows.Forms.Label();
      this.numStep = new System.Windows.Forms.NumericUpDown();
      this.numDegree = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.btnInsertRuleUpperF = new System.Windows.Forms.Button();
      this.btnInsertRuleLowerF = new System.Windows.Forms.Button();
      this.btnInsertRulePlus = new System.Windows.Forms.Button();
      this.btnInsertRuleMinus = new System.Windows.Forms.Button();
      this.btnInsertRuleBracketOpen = new System.Windows.Forms.Button();
      this.btnInsertRuleBracketClose = new System.Windows.Forms.Button();
      this.lblOpenedBrackets = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tbRuleset = new System.Windows.Forms.TextBox();
      this.btnGenerateRandomizedRuleset = new System.Windows.Forms.Button();
      this.btnGeneratePlant = new System.Windows.Forms.Button();
      this.prgsProcess = new System.Windows.Forms.ProgressBar();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.toolTipApp = new System.Windows.Forms.ToolTip(this.components);
      this.btnEraseRuleset = new System.Windows.Forms.Button();
      this.btnSaveRuleset = new System.Windows.Forms.Button();
      this.btnOpenRuleset = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numDegree)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Anzahl der Schritte";
      // 
      // numStep
      // 
      this.numStep.Location = new System.Drawing.Point(114, 24);
      this.numStep.Name = "numStep";
      this.numStep.Size = new System.Drawing.Size(41, 20);
      this.numStep.TabIndex = 1;
      this.toolTipApp.SetToolTip(this.numStep, "Anzahl der \'Verästelung\' (= Ebenen der Verzweigungen)");
      // 
      // numDegree
      // 
      this.numDegree.Location = new System.Drawing.Point(114, 50);
      this.numDegree.Name = "numDegree";
      this.numDegree.Size = new System.Drawing.Size(41, 20);
      this.numDegree.TabIndex = 3;
      this.toolTipApp.SetToolTip(this.numDegree, "Größe der Winkel, in der ein Zweig geneigt ist");
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Winkel in Grad";
      // 
      // btnInsertRuleUpperF
      // 
      this.btnInsertRuleUpperF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertRuleUpperF.Location = new System.Drawing.Point(15, 82);
      this.btnInsertRuleUpperF.Name = "btnInsertRuleUpperF";
      this.btnInsertRuleUpperF.Size = new System.Drawing.Size(23, 23);
      this.btnInsertRuleUpperF.TabIndex = 4;
      this.btnInsertRuleUpperF.Text = "F";
      this.toolTipApp.SetToolTip(this.btnInsertRuleUpperF, "Symbolik \'F\' erläutern");
      this.btnInsertRuleUpperF.UseVisualStyleBackColor = true;
      this.btnInsertRuleUpperF.Click += new System.EventHandler(this.btnInsertRuleUpperF_Click);
      // 
      // btnInsertRuleLowerF
      // 
      this.btnInsertRuleLowerF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertRuleLowerF.Location = new System.Drawing.Point(43, 82);
      this.btnInsertRuleLowerF.Name = "btnInsertRuleLowerF";
      this.btnInsertRuleLowerF.Size = new System.Drawing.Size(23, 23);
      this.btnInsertRuleLowerF.TabIndex = 5;
      this.btnInsertRuleLowerF.Text = "f";
      this.toolTipApp.SetToolTip(this.btnInsertRuleLowerF, "Symbolik \'f\' erläutern");
      this.btnInsertRuleLowerF.UseVisualStyleBackColor = true;
      this.btnInsertRuleLowerF.Click += new System.EventHandler(this.btnInsertRuleLowerF_Click);
      // 
      // btnInsertRulePlus
      // 
      this.btnInsertRulePlus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertRulePlus.Location = new System.Drawing.Point(72, 82);
      this.btnInsertRulePlus.Name = "btnInsertRulePlus";
      this.btnInsertRulePlus.Size = new System.Drawing.Size(23, 23);
      this.btnInsertRulePlus.TabIndex = 6;
      this.btnInsertRulePlus.Text = "+";
      this.toolTipApp.SetToolTip(this.btnInsertRulePlus, "Symbolik \'+\' erläutern");
      this.btnInsertRulePlus.UseVisualStyleBackColor = true;
      this.btnInsertRulePlus.Click += new System.EventHandler(this.btnInsertRulePlus_Click);
      // 
      // btnInsertRuleMinus
      // 
      this.btnInsertRuleMinus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertRuleMinus.Location = new System.Drawing.Point(101, 82);
      this.btnInsertRuleMinus.Name = "btnInsertRuleMinus";
      this.btnInsertRuleMinus.Size = new System.Drawing.Size(23, 23);
      this.btnInsertRuleMinus.TabIndex = 7;
      this.btnInsertRuleMinus.Text = "-";
      this.toolTipApp.SetToolTip(this.btnInsertRuleMinus, "Symbolik \'-\' erläutern");
      this.btnInsertRuleMinus.UseVisualStyleBackColor = true;
      this.btnInsertRuleMinus.Click += new System.EventHandler(this.btnInsertRuleMinus_Click);
      // 
      // btnInsertRuleBracketOpen
      // 
      this.btnInsertRuleBracketOpen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertRuleBracketOpen.Location = new System.Drawing.Point(130, 82);
      this.btnInsertRuleBracketOpen.Name = "btnInsertRuleBracketOpen";
      this.btnInsertRuleBracketOpen.Size = new System.Drawing.Size(23, 23);
      this.btnInsertRuleBracketOpen.TabIndex = 8;
      this.btnInsertRuleBracketOpen.Text = "[";
      this.toolTipApp.SetToolTip(this.btnInsertRuleBracketOpen, "Symbolik \'[\' erläutern");
      this.btnInsertRuleBracketOpen.UseVisualStyleBackColor = true;
      this.btnInsertRuleBracketOpen.Click += new System.EventHandler(this.btnInsertRuleBracketOpen_Click);
      // 
      // btnInsertRuleBracketClose
      // 
      this.btnInsertRuleBracketClose.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInsertRuleBracketClose.Location = new System.Drawing.Point(159, 82);
      this.btnInsertRuleBracketClose.Name = "btnInsertRuleBracketClose";
      this.btnInsertRuleBracketClose.Size = new System.Drawing.Size(23, 23);
      this.btnInsertRuleBracketClose.TabIndex = 9;
      this.btnInsertRuleBracketClose.Text = "]";
      this.toolTipApp.SetToolTip(this.btnInsertRuleBracketClose, "Symbolik \']\' erläutern");
      this.btnInsertRuleBracketClose.UseVisualStyleBackColor = true;
      this.btnInsertRuleBracketClose.Click += new System.EventHandler(this.btnInsertRuleBracketClose_Click);
      // 
      // lblOpenedBrackets
      // 
      this.lblOpenedBrackets.AutoSize = true;
      this.lblOpenedBrackets.Location = new System.Drawing.Point(15, 108);
      this.lblOpenedBrackets.Name = "lblOpenedBrackets";
      this.lblOpenedBrackets.Size = new System.Drawing.Size(94, 13);
      this.lblOpenedBrackets.TabIndex = 10;
      this.lblOpenedBrackets.Text = "Offene Klammern: ";
      this.toolTipApp.SetToolTip(this.lblOpenedBrackets, "Zeigt die offenen Klammer in der Ersetzungsregel an");
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 132);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(113, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Ersetzungsregel für \'F\':";
      // 
      // tbRuleset
      // 
      this.tbRuleset.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbRuleset.Location = new System.Drawing.Point(15, 149);
      this.tbRuleset.Name = "tbRuleset";
      this.tbRuleset.Size = new System.Drawing.Size(110, 20);
      this.tbRuleset.TabIndex = 12;
      this.toolTipApp.SetToolTip(this.tbRuleset, "Eingabe der Ersetzungsregeln für die Bildung der Pflanze");
      // 
      // btnGenerateRandomizedRuleset
      // 
      this.btnGenerateRandomizedRuleset.Location = new System.Drawing.Point(131, 147);
      this.btnGenerateRandomizedRuleset.Name = "btnGenerateRandomizedRuleset";
      this.btnGenerateRandomizedRuleset.Size = new System.Drawing.Size(51, 23);
      this.btnGenerateRandomizedRuleset.TabIndex = 13;
      this.btnGenerateRandomizedRuleset.Text = "&RND";
      this.toolTipApp.SetToolTip(this.btnGenerateRandomizedRuleset, "Erstellt eine pseudo-zufällige Ersetzungsregel");
      this.btnGenerateRandomizedRuleset.UseVisualStyleBackColor = true;
      this.btnGenerateRandomizedRuleset.Click += new System.EventHandler(this.btnGenerateRandomizedRuleset_Click);
      // 
      // btnGeneratePlant
      // 
      this.btnGeneratePlant.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneratePlant.Image")));
      this.btnGeneratePlant.Location = new System.Drawing.Point(42, 229);
      this.btnGeneratePlant.Name = "btnGeneratePlant";
      this.btnGeneratePlant.Size = new System.Drawing.Size(111, 23);
      this.btnGeneratePlant.TabIndex = 19;
      this.btnGeneratePlant.Text = "Pflanze &erstellen";
      this.btnGeneratePlant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipApp.SetToolTip(this.btnGeneratePlant, "Erstellt die Pflanze");
      this.btnGeneratePlant.UseVisualStyleBackColor = true;
      this.btnGeneratePlant.Click += new System.EventHandler(this.btnGeneratePlant_Click);
      // 
      // prgsProcess
      // 
      this.prgsProcess.Location = new System.Drawing.Point(213, 229);
      this.prgsProcess.Name = "prgsProcess";
      this.prgsProcess.Size = new System.Drawing.Size(211, 23);
      this.prgsProcess.TabIndex = 21;
      this.toolTipApp.SetToolTip(this.prgsProcess, "Fortschrittsbalken der Generierung der Pflanze");
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Location = new System.Drawing.Point(213, 13);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(211, 198);
      this.groupBox1.TabIndex = 20;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Ansicht";
      this.toolTipApp.SetToolTip(this.groupBox1, "Ansicht der Pflanze");
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.White;
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.Location = new System.Drawing.Point(6, 19);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(199, 173);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // toolTipApp
      // 
      this.toolTipApp.ShowAlways = true;
      this.toolTipApp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.toolTipApp.ToolTipTitle = "Hinweis";
      // 
      // btnEraseRuleset
      // 
      this.btnEraseRuleset.Image = ((System.Drawing.Image)(resources.GetObject("btnEraseRuleset.Image")));
      this.btnEraseRuleset.Location = new System.Drawing.Point(101, 175);
      this.btnEraseRuleset.Name = "btnEraseRuleset";
      this.btnEraseRuleset.Size = new System.Drawing.Size(23, 23);
      this.btnEraseRuleset.TabIndex = 17;
      this.toolTipApp.SetToolTip(this.btnEraseRuleset, "Löscht die komplette Ersetzungsregel");
      this.btnEraseRuleset.UseVisualStyleBackColor = true;
      this.btnEraseRuleset.Click += new System.EventHandler(this.btnEraseRuleset_Click);
      // 
      // btnSaveRuleset
      // 
      this.btnSaveRuleset.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveRuleset.Image")));
      this.btnSaveRuleset.Location = new System.Drawing.Point(43, 175);
      this.btnSaveRuleset.Name = "btnSaveRuleset";
      this.btnSaveRuleset.Size = new System.Drawing.Size(23, 23);
      this.btnSaveRuleset.TabIndex = 15;
      this.toolTipApp.SetToolTip(this.btnSaveRuleset, "Speichert eine Ersetzungsregel in eine Datei");
      this.btnSaveRuleset.UseVisualStyleBackColor = true;
      this.btnSaveRuleset.Click += new System.EventHandler(this.btnSaveRuleset_Click);
      // 
      // btnOpenRuleset
      // 
      this.btnOpenRuleset.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenRuleset.Image")));
      this.btnOpenRuleset.Location = new System.Drawing.Point(15, 175);
      this.btnOpenRuleset.Name = "btnOpenRuleset";
      this.btnOpenRuleset.Size = new System.Drawing.Size(23, 23);
      this.btnOpenRuleset.TabIndex = 14;
      this.toolTipApp.SetToolTip(this.btnOpenRuleset, "Öffnet eine Ersetzungsregel aus einer Datei");
      this.btnOpenRuleset.UseVisualStyleBackColor = true;
      this.btnOpenRuleset.Click += new System.EventHandler(this.btnOpenRuleset_Click);
      // 
      // PlantageForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(843, 615);
      this.Controls.Add(this.btnEraseRuleset);
      this.Controls.Add(this.btnSaveRuleset);
      this.Controls.Add(this.btnOpenRuleset);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.prgsProcess);
      this.Controls.Add(this.btnGeneratePlant);
      this.Controls.Add(this.btnGenerateRandomizedRuleset);
      this.Controls.Add(this.tbRuleset);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.lblOpenedBrackets);
      this.Controls.Add(this.btnInsertRuleBracketClose);
      this.Controls.Add(this.btnInsertRuleBracketOpen);
      this.Controls.Add(this.btnInsertRuleMinus);
      this.Controls.Add(this.btnInsertRulePlus);
      this.Controls.Add(this.btnInsertRuleLowerF);
      this.Controls.Add(this.btnInsertRuleUpperF);
      this.Controls.Add(this.numDegree);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.numStep);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "PlantageForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Plantage";
      this.Load += new System.EventHandler(this.PlantageForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numDegree)).EndInit();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numStep;
    private System.Windows.Forms.NumericUpDown numDegree;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnInsertRuleUpperF;
    private System.Windows.Forms.Button btnInsertRuleLowerF;
    private System.Windows.Forms.Button btnInsertRulePlus;
    private System.Windows.Forms.Button btnInsertRuleMinus;
    private System.Windows.Forms.Button btnInsertRuleBracketOpen;
    private System.Windows.Forms.Button btnInsertRuleBracketClose;
    private System.Windows.Forms.Label lblOpenedBrackets;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbRuleset;
    private System.Windows.Forms.Button btnGenerateRandomizedRuleset;
    private System.Windows.Forms.Button btnGeneratePlant;
    private System.Windows.Forms.ProgressBar prgsProcess;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ToolTip toolTipApp;
    private System.Windows.Forms.Button btnEraseRuleset;
    private System.Windows.Forms.Button btnSaveRuleset;
    private System.Windows.Forms.Button btnOpenRuleset;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

