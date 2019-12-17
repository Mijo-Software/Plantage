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
			this.labelStep = new System.Windows.Forms.Label();
			this.numStep = new System.Windows.Forms.NumericUpDown();
			this.numAngle = new System.Windows.Forms.NumericUpDown();
			this.labelAngle = new System.Windows.Forms.Label();
			this.buttonInsertRuleUpperF = new System.Windows.Forms.Button();
			this.buttonInsertRuleLowerF = new System.Windows.Forms.Button();
			this.buttonInsertRulePlus = new System.Windows.Forms.Button();
			this.buttonInsertRuleMinus = new System.Windows.Forms.Button();
			this.buttonInsertRuleBracketOpen = new System.Windows.Forms.Button();
			this.buttonInsertRuleBracketClose = new System.Windows.Forms.Button();
			this.labelOpenedBrackets = new System.Windows.Forms.Label();
			this.labelRuleSet = new System.Windows.Forms.Label();
			this.textboxRuleset = new System.Windows.Forms.TextBox();
			this.buttonGenerateRandomizedRuleset = new System.Windows.Forms.Button();
			this.buttonGeneratePlant = new System.Windows.Forms.Button();
			this.prgsProcess = new System.Windows.Forms.ProgressBar();
			this.groupBoxCanvas = new System.Windows.Forms.GroupBox();
			this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
			this.toolTipApp = new System.Windows.Forms.ToolTip(this.components);
			this.buttonEraseRuleset = new System.Windows.Forms.Button();
			this.buttonSaveRuleset = new System.Windows.Forms.Button();
			this.buttonOpenRuleset = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAngle)).BeginInit();
			this.groupBoxCanvas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// labelStep
			// 
			this.labelStep.AutoSize = true;
			this.labelStep.Location = new System.Drawing.Point(12, 26);
			this.labelStep.Name = "labelStep";
			this.labelStep.Size = new System.Drawing.Size(96, 13);
			this.labelStep.TabIndex = 0;
			this.labelStep.Text = "Anzahl der Schritte";
			// 
			// numStep
			// 
			this.numStep.Location = new System.Drawing.Point(114, 24);
			this.numStep.Name = "numStep";
			this.numStep.Size = new System.Drawing.Size(41, 20);
			this.numStep.TabIndex = 1;
			this.toolTipApp.SetToolTip(this.numStep, "Anzahl der \'Verästelung\' (= Ebenen der Verzweigungen)");
			// 
			// numAngle
			// 
			this.numAngle.Location = new System.Drawing.Point(114, 50);
			this.numAngle.Name = "numAngle";
			this.numAngle.Size = new System.Drawing.Size(41, 20);
			this.numAngle.TabIndex = 3;
			this.toolTipApp.SetToolTip(this.numAngle, "Größe der Winkel, in der ein Zweig geneigt ist");
			// 
			// labelAngle
			// 
			this.labelAngle.AutoSize = true;
			this.labelAngle.Location = new System.Drawing.Point(12, 52);
			this.labelAngle.Name = "labelAngle";
			this.labelAngle.Size = new System.Drawing.Size(77, 13);
			this.labelAngle.TabIndex = 2;
			this.labelAngle.Text = "Winkel in Grad";
			// 
			// buttonInsertRuleUpperF
			// 
			this.buttonInsertRuleUpperF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInsertRuleUpperF.Location = new System.Drawing.Point(15, 82);
			this.buttonInsertRuleUpperF.Name = "buttonInsertRuleUpperF";
			this.buttonInsertRuleUpperF.Size = new System.Drawing.Size(23, 23);
			this.buttonInsertRuleUpperF.TabIndex = 4;
			this.buttonInsertRuleUpperF.Text = "F";
			this.toolTipApp.SetToolTip(this.buttonInsertRuleUpperF, "Symbolik \'F\' erläutern");
			this.buttonInsertRuleUpperF.UseVisualStyleBackColor = true;
			this.buttonInsertRuleUpperF.Click += new System.EventHandler(this.ButtonInsertRuleUpperF_Click);
			// 
			// buttonInsertRuleLowerF
			// 
			this.buttonInsertRuleLowerF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInsertRuleLowerF.Location = new System.Drawing.Point(43, 82);
			this.buttonInsertRuleLowerF.Name = "buttonInsertRuleLowerF";
			this.buttonInsertRuleLowerF.Size = new System.Drawing.Size(23, 23);
			this.buttonInsertRuleLowerF.TabIndex = 5;
			this.buttonInsertRuleLowerF.Text = "f";
			this.toolTipApp.SetToolTip(this.buttonInsertRuleLowerF, "Symbolik \'f\' erläutern");
			this.buttonInsertRuleLowerF.UseVisualStyleBackColor = true;
			this.buttonInsertRuleLowerF.Click += new System.EventHandler(this.ButtonInsertRuleLowerF_Click);
			// 
			// buttonInsertRulePlus
			// 
			this.buttonInsertRulePlus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInsertRulePlus.Location = new System.Drawing.Point(72, 82);
			this.buttonInsertRulePlus.Name = "buttonInsertRulePlus";
			this.buttonInsertRulePlus.Size = new System.Drawing.Size(23, 23);
			this.buttonInsertRulePlus.TabIndex = 6;
			this.buttonInsertRulePlus.Text = "+";
			this.toolTipApp.SetToolTip(this.buttonInsertRulePlus, "Symbolik \'+\' erläutern");
			this.buttonInsertRulePlus.UseVisualStyleBackColor = true;
			this.buttonInsertRulePlus.Click += new System.EventHandler(this.ButtonInsertRulePlus_Click);
			// 
			// buttonInsertRuleMinus
			// 
			this.buttonInsertRuleMinus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInsertRuleMinus.Location = new System.Drawing.Point(101, 82);
			this.buttonInsertRuleMinus.Name = "buttonInsertRuleMinus";
			this.buttonInsertRuleMinus.Size = new System.Drawing.Size(23, 23);
			this.buttonInsertRuleMinus.TabIndex = 7;
			this.buttonInsertRuleMinus.Text = "-";
			this.toolTipApp.SetToolTip(this.buttonInsertRuleMinus, "Symbolik \'-\' erläutern");
			this.buttonInsertRuleMinus.UseVisualStyleBackColor = true;
			this.buttonInsertRuleMinus.Click += new System.EventHandler(this.ButtonInsertRuleMinus_Click);
			// 
			// buttonInsertRuleBracketOpen
			// 
			this.buttonInsertRuleBracketOpen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInsertRuleBracketOpen.Location = new System.Drawing.Point(130, 82);
			this.buttonInsertRuleBracketOpen.Name = "buttonInsertRuleBracketOpen";
			this.buttonInsertRuleBracketOpen.Size = new System.Drawing.Size(23, 23);
			this.buttonInsertRuleBracketOpen.TabIndex = 8;
			this.buttonInsertRuleBracketOpen.Text = "[";
			this.toolTipApp.SetToolTip(this.buttonInsertRuleBracketOpen, "Symbolik \'[\' erläutern");
			this.buttonInsertRuleBracketOpen.UseVisualStyleBackColor = true;
			this.buttonInsertRuleBracketOpen.Click += new System.EventHandler(this.ButtonInsertRuleBracketOpen_Click);
			// 
			// buttonInsertRuleBracketClose
			// 
			this.buttonInsertRuleBracketClose.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonInsertRuleBracketClose.Location = new System.Drawing.Point(159, 82);
			this.buttonInsertRuleBracketClose.Name = "buttonInsertRuleBracketClose";
			this.buttonInsertRuleBracketClose.Size = new System.Drawing.Size(23, 23);
			this.buttonInsertRuleBracketClose.TabIndex = 9;
			this.buttonInsertRuleBracketClose.Text = "]";
			this.toolTipApp.SetToolTip(this.buttonInsertRuleBracketClose, "Symbolik \']\' erläutern");
			this.buttonInsertRuleBracketClose.UseVisualStyleBackColor = true;
			this.buttonInsertRuleBracketClose.Click += new System.EventHandler(this.ButtonInsertRuleBracketClose_Click);
			// 
			// labelOpenedBrackets
			// 
			this.labelOpenedBrackets.AutoSize = true;
			this.labelOpenedBrackets.Location = new System.Drawing.Point(15, 108);
			this.labelOpenedBrackets.Name = "labelOpenedBrackets";
			this.labelOpenedBrackets.Size = new System.Drawing.Size(94, 13);
			this.labelOpenedBrackets.TabIndex = 10;
			this.labelOpenedBrackets.Text = "Offene Klammern: ";
			this.toolTipApp.SetToolTip(this.labelOpenedBrackets, "Zeigt die offenen Klammer in der Ersetzungsregel an");
			// 
			// labelRuleSet
			// 
			this.labelRuleSet.AutoSize = true;
			this.labelRuleSet.Location = new System.Drawing.Point(12, 132);
			this.labelRuleSet.Name = "labelRuleSet";
			this.labelRuleSet.Size = new System.Drawing.Size(113, 13);
			this.labelRuleSet.TabIndex = 11;
			this.labelRuleSet.Text = "Ersetzungsregel für \'F\':";
			// 
			// textboxRuleset
			// 
			this.textboxRuleset.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textboxRuleset.Location = new System.Drawing.Point(15, 149);
			this.textboxRuleset.Name = "textboxRuleset";
			this.textboxRuleset.Size = new System.Drawing.Size(110, 20);
			this.textboxRuleset.TabIndex = 12;
			this.toolTipApp.SetToolTip(this.textboxRuleset, "Eingabe der Ersetzungsregeln für die Bildung der Pflanze");
			// 
			// buttonGenerateRandomizedRuleset
			// 
			this.buttonGenerateRandomizedRuleset.Location = new System.Drawing.Point(131, 147);
			this.buttonGenerateRandomizedRuleset.Name = "buttonGenerateRandomizedRuleset";
			this.buttonGenerateRandomizedRuleset.Size = new System.Drawing.Size(51, 23);
			this.buttonGenerateRandomizedRuleset.TabIndex = 13;
			this.buttonGenerateRandomizedRuleset.Text = "&RND";
			this.toolTipApp.SetToolTip(this.buttonGenerateRandomizedRuleset, "Erstellt eine pseudo-zufällige Ersetzungsregel");
			this.buttonGenerateRandomizedRuleset.UseVisualStyleBackColor = true;
			this.buttonGenerateRandomizedRuleset.Click += new System.EventHandler(this.ButtonGenerateRandomizedRuleset_Click);
			// 
			// buttonGeneratePlant
			// 
			this.buttonGeneratePlant.Image = ((System.Drawing.Image)(resources.GetObject("buttonGeneratePlant.Image")));
			this.buttonGeneratePlant.Location = new System.Drawing.Point(42, 229);
			this.buttonGeneratePlant.Name = "buttonGeneratePlant";
			this.buttonGeneratePlant.Size = new System.Drawing.Size(111, 23);
			this.buttonGeneratePlant.TabIndex = 19;
			this.buttonGeneratePlant.Text = "Pflanze &erstellen";
			this.buttonGeneratePlant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTipApp.SetToolTip(this.buttonGeneratePlant, "Erstellt die Pflanze");
			this.buttonGeneratePlant.UseVisualStyleBackColor = true;
			this.buttonGeneratePlant.Click += new System.EventHandler(this.ButtonGeneratePlant_Click);
			// 
			// prgsProcess
			// 
			this.prgsProcess.Location = new System.Drawing.Point(213, 229);
			this.prgsProcess.Name = "prgsProcess";
			this.prgsProcess.Size = new System.Drawing.Size(211, 23);
			this.prgsProcess.TabIndex = 21;
			this.toolTipApp.SetToolTip(this.prgsProcess, "Fortschrittsbalken der Generierung der Pflanze");
			// 
			// groupBoxCanvas
			// 
			this.groupBoxCanvas.Controls.Add(this.pictureBoxCanvas);
			this.groupBoxCanvas.Location = new System.Drawing.Point(213, 13);
			this.groupBoxCanvas.Name = "groupBoxCanvas";
			this.groupBoxCanvas.Size = new System.Drawing.Size(211, 198);
			this.groupBoxCanvas.TabIndex = 20;
			this.groupBoxCanvas.TabStop = false;
			this.groupBoxCanvas.Text = "Ansicht";
			this.toolTipApp.SetToolTip(this.groupBoxCanvas, "Ansicht der Pflanze");
			// 
			// pictureBoxCanvas
			// 
			this.pictureBoxCanvas.BackColor = System.Drawing.Color.White;
			this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxCanvas.Location = new System.Drawing.Point(6, 19);
			this.pictureBoxCanvas.Name = "pictureBoxCanvas";
			this.pictureBoxCanvas.Size = new System.Drawing.Size(199, 173);
			this.pictureBoxCanvas.TabIndex = 0;
			this.pictureBoxCanvas.TabStop = false;
			// 
			// toolTipApp
			// 
			this.toolTipApp.ShowAlways = true;
			this.toolTipApp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTipApp.ToolTipTitle = "Hinweis";
			// 
			// buttonEraseRuleset
			// 
			this.buttonEraseRuleset.Image = ((System.Drawing.Image)(resources.GetObject("buttonEraseRuleset.Image")));
			this.buttonEraseRuleset.Location = new System.Drawing.Point(101, 175);
			this.buttonEraseRuleset.Name = "buttonEraseRuleset";
			this.buttonEraseRuleset.Size = new System.Drawing.Size(23, 23);
			this.buttonEraseRuleset.TabIndex = 17;
			this.toolTipApp.SetToolTip(this.buttonEraseRuleset, "Löscht die komplette Ersetzungsregel");
			this.buttonEraseRuleset.UseVisualStyleBackColor = true;
			this.buttonEraseRuleset.Click += new System.EventHandler(this.ButtonEraseRuleset_Click);
			// 
			// buttonSaveRuleset
			// 
			this.buttonSaveRuleset.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveRuleset.Image")));
			this.buttonSaveRuleset.Location = new System.Drawing.Point(43, 175);
			this.buttonSaveRuleset.Name = "buttonSaveRuleset";
			this.buttonSaveRuleset.Size = new System.Drawing.Size(23, 23);
			this.buttonSaveRuleset.TabIndex = 15;
			this.toolTipApp.SetToolTip(this.buttonSaveRuleset, "Speichert eine Ersetzungsregel in eine Datei");
			this.buttonSaveRuleset.UseVisualStyleBackColor = true;
			this.buttonSaveRuleset.Click += new System.EventHandler(this.ButtonSaveRuleset_Click);
			// 
			// buttonOpenRuleset
			// 
			this.buttonOpenRuleset.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenRuleset.Image")));
			this.buttonOpenRuleset.Location = new System.Drawing.Point(15, 175);
			this.buttonOpenRuleset.Name = "buttonOpenRuleset";
			this.buttonOpenRuleset.Size = new System.Drawing.Size(23, 23);
			this.buttonOpenRuleset.TabIndex = 14;
			this.toolTipApp.SetToolTip(this.buttonOpenRuleset, "Öffnet eine Ersetzungsregel aus einer Datei");
			this.buttonOpenRuleset.UseVisualStyleBackColor = true;
			this.buttonOpenRuleset.Click += new System.EventHandler(this.ButtonOpenRuleset_Click);
			// 
			// PlantageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 615);
			this.Controls.Add(this.buttonEraseRuleset);
			this.Controls.Add(this.buttonSaveRuleset);
			this.Controls.Add(this.buttonOpenRuleset);
			this.Controls.Add(this.groupBoxCanvas);
			this.Controls.Add(this.prgsProcess);
			this.Controls.Add(this.buttonGeneratePlant);
			this.Controls.Add(this.buttonGenerateRandomizedRuleset);
			this.Controls.Add(this.textboxRuleset);
			this.Controls.Add(this.labelRuleSet);
			this.Controls.Add(this.labelOpenedBrackets);
			this.Controls.Add(this.buttonInsertRuleBracketClose);
			this.Controls.Add(this.buttonInsertRuleBracketOpen);
			this.Controls.Add(this.buttonInsertRuleMinus);
			this.Controls.Add(this.buttonInsertRulePlus);
			this.Controls.Add(this.buttonInsertRuleLowerF);
			this.Controls.Add(this.buttonInsertRuleUpperF);
			this.Controls.Add(this.numAngle);
			this.Controls.Add(this.labelAngle);
			this.Controls.Add(this.numStep);
			this.Controls.Add(this.labelStep);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PlantageForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Plantage";
			this.Load += new System.EventHandler(this.PlantageForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAngle)).EndInit();
			this.groupBoxCanvas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelStep;
    private System.Windows.Forms.NumericUpDown numStep;
    private System.Windows.Forms.NumericUpDown numAngle;
    private System.Windows.Forms.Label labelAngle;
    private System.Windows.Forms.Button buttonInsertRuleUpperF;
    private System.Windows.Forms.Button buttonInsertRuleLowerF;
    private System.Windows.Forms.Button buttonInsertRulePlus;
    private System.Windows.Forms.Button buttonInsertRuleMinus;
    private System.Windows.Forms.Button buttonInsertRuleBracketOpen;
    private System.Windows.Forms.Button buttonInsertRuleBracketClose;
    private System.Windows.Forms.Label labelOpenedBrackets;
    private System.Windows.Forms.Label labelRuleSet;
    private System.Windows.Forms.TextBox textboxRuleset;
    private System.Windows.Forms.Button buttonGenerateRandomizedRuleset;
    private System.Windows.Forms.Button buttonGeneratePlant;
    private System.Windows.Forms.ProgressBar prgsProcess;
    private System.Windows.Forms.GroupBox groupBoxCanvas;
    private System.Windows.Forms.ToolTip toolTipApp;
    private System.Windows.Forms.Button buttonEraseRuleset;
    private System.Windows.Forms.Button buttonSaveRuleset;
    private System.Windows.Forms.Button buttonOpenRuleset;
    private System.Windows.Forms.PictureBox pictureBoxCanvas;
  }
}

