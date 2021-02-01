namespace DndApplication
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
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerNameTxt = new System.Windows.Forms.ComboBox();
            this.targetedPlayerHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthTxt = new System.Windows.Forms.TextBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.encounterRoundTxt = new System.Windows.Forms.TextBox();
            this.actionTakenLabel = new System.Windows.Forms.Label();
            this.actionTakenTxt = new System.Windows.Forms.ComboBox();
            this.targetedPlayerLabel = new System.Windows.Forms.Label();
            this.targetedPlayerTxt = new System.Windows.Forms.ComboBox();
            this.damageDoneToTargetLabel = new System.Windows.Forms.Label();
            this.damageDoneToTargetTxt = new System.Windows.Forms.TextBox();
            this.healingDoneToTargetLabel = new System.Windows.Forms.Label();
            this.healingDoneToTargetTxt = new System.Windows.Forms.TextBox();
            this.targetedPlayerHealthTxt = new System.Windows.Forms.TextBox();
            this.calculateAndInset = new System.Windows.Forms.Button();
            this.lariesHpLabel = new System.Windows.Forms.Label();
            this.baublesHpLabel = new System.Windows.Forms.Label();
            this.baublesHealthTxt = new System.Windows.Forms.TextBox();
            this.phaosHpLabel = new System.Windows.Forms.Label();
            this.phaosHealthTxt = new System.Windows.Forms.TextBox();
            this.draydenHpLabel = new System.Windows.Forms.Label();
            this.draydensHealthTxt = new System.Windows.Forms.TextBox();
            this.ragearsHpLabel = new System.Windows.Forms.Label();
            this.ragearsHelathTxt = new System.Windows.Forms.TextBox();
            this.errorBox = new System.Windows.Forms.TextBox();
            this.lariesHealthTxt = new System.Windows.Forms.TextBox();
            this.dmgDoneToEveryoneTxt = new System.Windows.Forms.ListBox();
            this.healingDoneToFriendlyTxt = new System.Windows.Forms.ListBox();
            this.longRestButton = new System.Windows.Forms.Button();
            this.dmgDoneByPartyMembersTxt = new System.Windows.Forms.ListBox();
            this.updateDashoBoard = new System.Windows.Forms.Button();
            this.clearCombatColumn = new System.Windows.Forms.Button();
            this.lunasHealthTxt = new System.Windows.Forms.TextBox();
            this.lunaHpLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.playerNameLabel.ForeColor = System.Drawing.Color.White;
            this.playerNameLabel.Location = new System.Drawing.Point(13, 65);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(96, 19);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "Player Name";
            this.playerNameLabel.Click += new System.EventHandler(this.playerNameLabel_Click);
            // 
            // playerNameTxt
            // 
            this.playerNameTxt.FormattingEnabled = true;
            this.playerNameTxt.ItemHeight = 13;
            this.playerNameTxt.Items.AddRange(new object[] {
            "Larie",
            "Baubles",
            "Drayden",
            "Rage-ar",
            "Phao",
            "Luna"});
            this.playerNameTxt.Location = new System.Drawing.Point(11, 85);
            this.playerNameTxt.Name = "playerNameTxt";
            this.playerNameTxt.Size = new System.Drawing.Size(121, 21);
            this.playerNameTxt.TabIndex = 2;
            this.playerNameTxt.TabStop = false;
            this.playerNameTxt.SelectedIndexChanged += new System.EventHandler(this.playerNameTxt_SelectedIndexChanged);
            // 
            // targetedPlayerHealthLabel
            // 
            this.targetedPlayerHealthLabel.AutoSize = true;
            this.targetedPlayerHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.targetedPlayerHealthLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.targetedPlayerHealthLabel.ForeColor = System.Drawing.Color.White;
            this.targetedPlayerHealthLabel.Location = new System.Drawing.Point(13, 262);
            this.targetedPlayerHealthLabel.Name = "targetedPlayerHealthLabel";
            this.targetedPlayerHealthLabel.Size = new System.Drawing.Size(163, 19);
            this.targetedPlayerHealthLabel.TabIndex = 0;
            this.targetedPlayerHealthLabel.Text = "Targeted Player Health";
            this.targetedPlayerHealthLabel.Click += new System.EventHandler(this.targetedPlayerHealthLabel_Click);
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHealthLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.playerHealthLabel.ForeColor = System.Drawing.Color.White;
            this.playerHealthLabel.Location = new System.Drawing.Point(12, 118);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(100, 19);
            this.playerHealthLabel.TabIndex = 0;
            this.playerHealthLabel.Text = "Player Health";
            this.playerHealthLabel.Click += new System.EventHandler(this.playerHealthLabel_Click);
            // 
            // playerHealthTxt
            // 
            this.playerHealthTxt.Location = new System.Drawing.Point(11, 138);
            this.playerHealthTxt.Name = "playerHealthTxt";
            this.playerHealthTxt.Size = new System.Drawing.Size(121, 20);
            this.playerHealthTxt.TabIndex = 0;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.White;
            this.roundLabel.Location = new System.Drawing.Point(12, 12);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(121, 19);
            this.roundLabel.TabIndex = 0;
            this.roundLabel.Text = "Encounter Round";
            this.roundLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // encounterRoundTxt
            // 
            this.encounterRoundTxt.BackColor = System.Drawing.SystemColors.Window;
            this.encounterRoundTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encounterRoundTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.encounterRoundTxt.Location = new System.Drawing.Point(11, 32);
            this.encounterRoundTxt.Name = "encounterRoundTxt";
            this.encounterRoundTxt.Size = new System.Drawing.Size(122, 20);
            this.encounterRoundTxt.TabIndex = 1;
            // 
            // actionTakenLabel
            // 
            this.actionTakenLabel.AutoSize = true;
            this.actionTakenLabel.BackColor = System.Drawing.Color.Transparent;
            this.actionTakenLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.actionTakenLabel.ForeColor = System.Drawing.Color.White;
            this.actionTakenLabel.Location = new System.Drawing.Point(12, 161);
            this.actionTakenLabel.Name = "actionTakenLabel";
            this.actionTakenLabel.Size = new System.Drawing.Size(94, 19);
            this.actionTakenLabel.TabIndex = 0;
            this.actionTakenLabel.Text = "Action Taken";
            this.actionTakenLabel.Click += new System.EventHandler(this.actionTakenLabel_Click);
            // 
            // actionTakenTxt
            // 
            this.actionTakenTxt.FormattingEnabled = true;
            this.actionTakenTxt.ItemHeight = 13;
            this.actionTakenTxt.Items.AddRange(new object[] {
            "Attack",
            "Heal"});
            this.actionTakenTxt.Location = new System.Drawing.Point(11, 183);
            this.actionTakenTxt.Name = "actionTakenTxt";
            this.actionTakenTxt.Size = new System.Drawing.Size(121, 21);
            this.actionTakenTxt.TabIndex = 3;
            // 
            // targetedPlayerLabel
            // 
            this.targetedPlayerLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.targetedPlayerLabel.AutoSize = true;
            this.targetedPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.targetedPlayerLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.targetedPlayerLabel.ForeColor = System.Drawing.Color.White;
            this.targetedPlayerLabel.Location = new System.Drawing.Point(13, 215);
            this.targetedPlayerLabel.Name = "targetedPlayerLabel";
            this.targetedPlayerLabel.Size = new System.Drawing.Size(115, 19);
            this.targetedPlayerLabel.TabIndex = 0;
            this.targetedPlayerLabel.Text = "Targeted Player";
            this.targetedPlayerLabel.Click += new System.EventHandler(this.targetedPlayerLabel_Click);
            // 
            // targetedPlayerTxt
            // 
            this.targetedPlayerTxt.FormattingEnabled = true;
            this.targetedPlayerTxt.Items.AddRange(new object[] {
            "Larie",
            "Baubles",
            "Drayden",
            "Rage-ar",
            "Phao",
            "Luna"});
            this.targetedPlayerTxt.Location = new System.Drawing.Point(11, 234);
            this.targetedPlayerTxt.Name = "targetedPlayerTxt";
            this.targetedPlayerTxt.Size = new System.Drawing.Size(121, 21);
            this.targetedPlayerTxt.TabIndex = 4;
            this.targetedPlayerTxt.SelectedIndexChanged += new System.EventHandler(this.targetedPlayerTxt_SelectedIndexChanged);
            // 
            // damageDoneToTargetLabel
            // 
            this.damageDoneToTargetLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.damageDoneToTargetLabel.AutoSize = true;
            this.damageDoneToTargetLabel.BackColor = System.Drawing.Color.Transparent;
            this.damageDoneToTargetLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.damageDoneToTargetLabel.ForeColor = System.Drawing.Color.White;
            this.damageDoneToTargetLabel.Location = new System.Drawing.Point(13, 310);
            this.damageDoneToTargetLabel.Name = "damageDoneToTargetLabel";
            this.damageDoneToTargetLabel.Size = new System.Drawing.Size(130, 19);
            this.damageDoneToTargetLabel.TabIndex = 0;
            this.damageDoneToTargetLabel.Text = "Damage To Target";
            this.damageDoneToTargetLabel.Click += new System.EventHandler(this.damageDoneToTargetLabel_Click);
            // 
            // damageDoneToTargetTxt
            // 
            this.damageDoneToTargetTxt.Location = new System.Drawing.Point(11, 329);
            this.damageDoneToTargetTxt.Name = "damageDoneToTargetTxt";
            this.damageDoneToTargetTxt.Size = new System.Drawing.Size(121, 20);
            this.damageDoneToTargetTxt.TabIndex = 5;
            // 
            // healingDoneToTargetLabel
            // 
            this.healingDoneToTargetLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.healingDoneToTargetLabel.AutoSize = true;
            this.healingDoneToTargetLabel.BackColor = System.Drawing.Color.Transparent;
            this.healingDoneToTargetLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.healingDoneToTargetLabel.ForeColor = System.Drawing.Color.White;
            this.healingDoneToTargetLabel.Location = new System.Drawing.Point(13, 352);
            this.healingDoneToTargetLabel.Name = "healingDoneToTargetLabel";
            this.healingDoneToTargetLabel.Size = new System.Drawing.Size(125, 19);
            this.healingDoneToTargetLabel.TabIndex = 0;
            this.healingDoneToTargetLabel.Text = "Healing To Target";
            this.healingDoneToTargetLabel.Click += new System.EventHandler(this.healingDoneToTargetLabel_Click);
            // 
            // healingDoneToTargetTxt
            // 
            this.healingDoneToTargetTxt.Location = new System.Drawing.Point(11, 371);
            this.healingDoneToTargetTxt.Name = "healingDoneToTargetTxt";
            this.healingDoneToTargetTxt.Size = new System.Drawing.Size(121, 20);
            this.healingDoneToTargetTxt.TabIndex = 6;
            // 
            // targetedPlayerHealthTxt
            // 
            this.targetedPlayerHealthTxt.Location = new System.Drawing.Point(11, 284);
            this.targetedPlayerHealthTxt.Name = "targetedPlayerHealthTxt";
            this.targetedPlayerHealthTxt.Size = new System.Drawing.Size(121, 20);
            this.targetedPlayerHealthTxt.TabIndex = 0;
            // 
            // calculateAndInset
            // 
            this.calculateAndInset.BackColor = System.Drawing.Color.Aqua;
            this.calculateAndInset.Location = new System.Drawing.Point(10, 414);
            this.calculateAndInset.Name = "calculateAndInset";
            this.calculateAndInset.Size = new System.Drawing.Size(153, 39);
            this.calculateAndInset.TabIndex = 7;
            this.calculateAndInset.Text = "Calculate and Insert";
            this.calculateAndInset.UseVisualStyleBackColor = false;
            this.calculateAndInset.Click += new System.EventHandler(this.calculateAndInset_Click);
            // 
            // lariesHpLabel
            // 
            this.lariesHpLabel.AutoSize = true;
            this.lariesHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.lariesHpLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lariesHpLabel.ForeColor = System.Drawing.Color.White;
            this.lariesHpLabel.Location = new System.Drawing.Point(212, 12);
            this.lariesHpLabel.Name = "lariesHpLabel";
            this.lariesHpLabel.Size = new System.Drawing.Size(100, 19);
            this.lariesHpLabel.TabIndex = 0;
            this.lariesHpLabel.Text = "Larie\'s Health";
            this.lariesHpLabel.Click += new System.EventHandler(this.lariesHpLabel_Click);
            // 
            // baublesHpLabel
            // 
            this.baublesHpLabel.AutoSize = true;
            this.baublesHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.baublesHpLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.baublesHpLabel.ForeColor = System.Drawing.Color.White;
            this.baublesHpLabel.Location = new System.Drawing.Point(213, 65);
            this.baublesHpLabel.Name = "baublesHpLabel";
            this.baublesHpLabel.Size = new System.Drawing.Size(118, 19);
            this.baublesHpLabel.TabIndex = 16;
            this.baublesHpLabel.Text = "Baubles\'s Health";
            this.baublesHpLabel.Click += new System.EventHandler(this.baublesHpLabel_Click);
            // 
            // baublesHealthTxt
            // 
            this.baublesHealthTxt.Location = new System.Drawing.Point(211, 84);
            this.baublesHealthTxt.Name = "baublesHealthTxt";
            this.baublesHealthTxt.Size = new System.Drawing.Size(121, 20);
            this.baublesHealthTxt.TabIndex = 0;
            // 
            // phaosHpLabel
            // 
            this.phaosHpLabel.AutoSize = true;
            this.phaosHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.phaosHpLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.phaosHpLabel.ForeColor = System.Drawing.Color.White;
            this.phaosHpLabel.Location = new System.Drawing.Point(337, 65);
            this.phaosHpLabel.Name = "phaosHpLabel";
            this.phaosHpLabel.Size = new System.Drawing.Size(100, 19);
            this.phaosHpLabel.TabIndex = 0;
            this.phaosHpLabel.Text = "Phao\'s Health";
            this.phaosHpLabel.Click += new System.EventHandler(this.phaosHpLabel_Click);
            // 
            // phaosHealthTxt
            // 
            this.phaosHealthTxt.Location = new System.Drawing.Point(335, 84);
            this.phaosHealthTxt.Name = "phaosHealthTxt";
            this.phaosHealthTxt.Size = new System.Drawing.Size(121, 20);
            this.phaosHealthTxt.TabIndex = 0;
            // 
            // draydenHpLabel
            // 
            this.draydenHpLabel.AutoSize = true;
            this.draydenHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.draydenHpLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.draydenHpLabel.ForeColor = System.Drawing.Color.White;
            this.draydenHpLabel.Location = new System.Drawing.Point(337, 118);
            this.draydenHpLabel.Name = "draydenHpLabel";
            this.draydenHpLabel.Size = new System.Drawing.Size(123, 19);
            this.draydenHpLabel.TabIndex = 0;
            this.draydenHpLabel.Text = "Drayden\'s Health";
            this.draydenHpLabel.Click += new System.EventHandler(this.draydenHpLabel_Click);
            // 
            // draydensHealthTxt
            // 
            this.draydensHealthTxt.Location = new System.Drawing.Point(335, 137);
            this.draydensHealthTxt.Name = "draydensHealthTxt";
            this.draydensHealthTxt.Size = new System.Drawing.Size(121, 20);
            this.draydensHealthTxt.TabIndex = 0;
            // 
            // ragearsHpLabel
            // 
            this.ragearsHpLabel.AutoSize = true;
            this.ragearsHpLabel.BackColor = System.Drawing.Color.Transparent;
            this.ragearsHpLabel.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ragearsHpLabel.ForeColor = System.Drawing.Color.White;
            this.ragearsHpLabel.Location = new System.Drawing.Point(337, 12);
            this.ragearsHpLabel.Name = "ragearsHpLabel";
            this.ragearsHpLabel.Size = new System.Drawing.Size(119, 19);
            this.ragearsHpLabel.TabIndex = 0;
            this.ragearsHpLabel.Text = "Rage-ar\'s Health";
            this.ragearsHpLabel.Click += new System.EventHandler(this.ragearsHpLabel_Click);
            // 
            // ragearsHelathTxt
            // 
            this.ragearsHelathTxt.Location = new System.Drawing.Point(335, 31);
            this.ragearsHelathTxt.Name = "ragearsHelathTxt";
            this.ragearsHelathTxt.Size = new System.Drawing.Size(121, 20);
            this.ragearsHelathTxt.TabIndex = 0;
            // 
            // errorBox
            // 
            this.errorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.ForeColor = System.Drawing.Color.Red;
            this.errorBox.Location = new System.Drawing.Point(10, 468);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(291, 23);
            this.errorBox.TabIndex = 0;
            // 
            // lariesHealthTxt
            // 
            this.lariesHealthTxt.Location = new System.Drawing.Point(210, 31);
            this.lariesHealthTxt.Name = "lariesHealthTxt";
            this.lariesHealthTxt.Size = new System.Drawing.Size(121, 20);
            this.lariesHealthTxt.TabIndex = 0;
            // 
            // dmgDoneToEveryoneTxt
            // 
            this.dmgDoneToEveryoneTxt.BackColor = System.Drawing.SystemColors.Window;
            this.dmgDoneToEveryoneTxt.FormattingEnabled = true;
            this.dmgDoneToEveryoneTxt.Location = new System.Drawing.Point(606, 8);
            this.dmgDoneToEveryoneTxt.Name = "dmgDoneToEveryoneTxt";
            this.dmgDoneToEveryoneTxt.Size = new System.Drawing.Size(288, 290);
            this.dmgDoneToEveryoneTxt.TabIndex = 0;
            // 
            // healingDoneToFriendlyTxt
            // 
            this.healingDoneToFriendlyTxt.BackColor = System.Drawing.SystemColors.Window;
            this.healingDoneToFriendlyTxt.FormattingEnabled = true;
            this.healingDoneToFriendlyTxt.Location = new System.Drawing.Point(900, 8);
            this.healingDoneToFriendlyTxt.Name = "healingDoneToFriendlyTxt";
            this.healingDoneToFriendlyTxt.Size = new System.Drawing.Size(199, 147);
            this.healingDoneToFriendlyTxt.TabIndex = 0;
            // 
            // longRestButton
            // 
            this.longRestButton.BackColor = System.Drawing.Color.Aqua;
            this.longRestButton.Location = new System.Drawing.Point(211, 170);
            this.longRestButton.Name = "longRestButton";
            this.longRestButton.Size = new System.Drawing.Size(245, 41);
            this.longRestButton.TabIndex = 9;
            this.longRestButton.Text = "Long Rest";
            this.longRestButton.UseVisualStyleBackColor = false;
            this.longRestButton.Click += new System.EventHandler(this.longRestButton_Click);
            // 
            // dmgDoneByPartyMembersTxt
            // 
            this.dmgDoneByPartyMembersTxt.BackColor = System.Drawing.SystemColors.Window;
            this.dmgDoneByPartyMembersTxt.FormattingEnabled = true;
            this.dmgDoneByPartyMembersTxt.Location = new System.Drawing.Point(900, 161);
            this.dmgDoneByPartyMembersTxt.Name = "dmgDoneByPartyMembersTxt";
            this.dmgDoneByPartyMembersTxt.Size = new System.Drawing.Size(199, 134);
            this.dmgDoneByPartyMembersTxt.TabIndex = 18;
            // 
            // updateDashoBoard
            // 
            this.updateDashoBoard.BackColor = System.Drawing.Color.Aqua;
            this.updateDashoBoard.Location = new System.Drawing.Point(478, 31);
            this.updateDashoBoard.Name = "updateDashoBoard";
            this.updateDashoBoard.Size = new System.Drawing.Size(122, 73);
            this.updateDashoBoard.TabIndex = 10;
            this.updateDashoBoard.Text = "Update Dashboard";
            this.updateDashoBoard.UseVisualStyleBackColor = false;
            this.updateDashoBoard.Click += new System.EventHandler(this.updateDashoBoard_Click);
            // 
            // clearCombatColumn
            // 
            this.clearCombatColumn.BackColor = System.Drawing.Color.Aqua;
            this.clearCombatColumn.Location = new System.Drawing.Point(184, 414);
            this.clearCombatColumn.Name = "clearCombatColumn";
            this.clearCombatColumn.Size = new System.Drawing.Size(117, 39);
            this.clearCombatColumn.TabIndex = 8;
            this.clearCombatColumn.Text = "Clear Column";
            this.clearCombatColumn.UseVisualStyleBackColor = false;
            this.clearCombatColumn.Click += new System.EventHandler(this.clearCombatColumn_Click);
            // 
            // lunasHealthTxt
            // 
            this.lunasHealthTxt.Location = new System.Drawing.Point(210, 137);
            this.lunasHealthTxt.Name = "lunasHealthTxt";
            this.lunasHealthTxt.Size = new System.Drawing.Size(121, 20);
            this.lunasHealthTxt.TabIndex = 19;
            // 
            // lunaHpLable
            // 
            this.lunaHpLable.AutoSize = true;
            this.lunaHpLable.BackColor = System.Drawing.Color.Transparent;
            this.lunaHpLable.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lunaHpLable.ForeColor = System.Drawing.Color.White;
            this.lunaHpLable.Location = new System.Drawing.Point(213, 115);
            this.lunaHpLable.Name = "lunaHpLable";
            this.lunaHpLable.Size = new System.Drawing.Size(98, 19);
            this.lunaHpLable.TabIndex = 20;
            this.lunaHpLable.Text = "Luna\'s Health";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 634);
            this.Controls.Add(this.lunaHpLable);
            this.Controls.Add(this.lunasHealthTxt);
            this.Controls.Add(this.clearCombatColumn);
            this.Controls.Add(this.updateDashoBoard);
            this.Controls.Add(this.dmgDoneByPartyMembersTxt);
            this.Controls.Add(this.longRestButton);
            this.Controls.Add(this.healingDoneToFriendlyTxt);
            this.Controls.Add(this.dmgDoneToEveryoneTxt);
            this.Controls.Add(this.lariesHealthTxt);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.ragearsHelathTxt);
            this.Controls.Add(this.ragearsHpLabel);
            this.Controls.Add(this.draydensHealthTxt);
            this.Controls.Add(this.draydenHpLabel);
            this.Controls.Add(this.phaosHealthTxt);
            this.Controls.Add(this.phaosHpLabel);
            this.Controls.Add(this.baublesHealthTxt);
            this.Controls.Add(this.baublesHpLabel);
            this.Controls.Add(this.lariesHpLabel);
            this.Controls.Add(this.calculateAndInset);
            this.Controls.Add(this.targetedPlayerHealthTxt);
            this.Controls.Add(this.healingDoneToTargetTxt);
            this.Controls.Add(this.healingDoneToTargetLabel);
            this.Controls.Add(this.damageDoneToTargetTxt);
            this.Controls.Add(this.damageDoneToTargetLabel);
            this.Controls.Add(this.targetedPlayerTxt);
            this.Controls.Add(this.targetedPlayerLabel);
            this.Controls.Add(this.actionTakenTxt);
            this.Controls.Add(this.actionTakenLabel);
            this.Controls.Add(this.encounterRoundTxt);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.playerHealthTxt);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.targetedPlayerHealthLabel);
            this.Controls.Add(this.playerNameTxt);
            this.Controls.Add(this.playerNameLabel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.ComboBox playerNameTxt;
        private System.Windows.Forms.Label targetedPlayerHealthLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.TextBox playerHealthTxt;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.TextBox encounterRoundTxt;
        private System.Windows.Forms.Label actionTakenLabel;
        private System.Windows.Forms.ComboBox actionTakenTxt;
        private System.Windows.Forms.Label targetedPlayerLabel;
        private System.Windows.Forms.ComboBox targetedPlayerTxt;
        private System.Windows.Forms.Label damageDoneToTargetLabel;
        private System.Windows.Forms.TextBox damageDoneToTargetTxt;
        private System.Windows.Forms.Label healingDoneToTargetLabel;
        private System.Windows.Forms.TextBox healingDoneToTargetTxt;
        private System.Windows.Forms.TextBox targetedPlayerHealthTxt;
        private System.Windows.Forms.Button calculateAndInset;
        private System.Windows.Forms.Label lariesHpLabel;
        private System.Windows.Forms.Label baublesHpLabel;
        private System.Windows.Forms.TextBox baublesHealthTxt;
        private System.Windows.Forms.Label phaosHpLabel;
        private System.Windows.Forms.TextBox phaosHealthTxt;
        private System.Windows.Forms.Label draydenHpLabel;
        private System.Windows.Forms.TextBox draydensHealthTxt;
        private System.Windows.Forms.Label ragearsHpLabel;
        private System.Windows.Forms.TextBox ragearsHelathTxt;
        private System.Windows.Forms.TextBox errorBox;
        private System.Windows.Forms.TextBox lariesHealthTxt;
        private System.Windows.Forms.ListBox dmgDoneToEveryoneTxt;
        private System.Windows.Forms.ListBox healingDoneToFriendlyTxt;
        private System.Windows.Forms.Button longRestButton;
        private System.Windows.Forms.ListBox dmgDoneByPartyMembersTxt;
        private System.Windows.Forms.Button updateDashoBoard;
        private System.Windows.Forms.Button clearCombatColumn;
        private System.Windows.Forms.TextBox lunasHealthTxt;
        private System.Windows.Forms.Label lunaHpLable;
    }
}

