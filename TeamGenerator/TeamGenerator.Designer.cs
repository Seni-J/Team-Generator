namespace TeamGenerator
{
    partial class TeamGenerator
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbladdMember = new System.Windows.Forms.Label();
            this.txtAddMember = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstMembers = new System.Windows.Forms.ListView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnDeleteName = new System.Windows.Forms.Button();
            this.lstTeamOne = new System.Windows.Forms.ListView();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.lstTeamTwo = new System.Windows.Forms.ListView();
            this.btnTeamReset = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(209, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(370, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TEAM GENERATOR";
            // 
            // lbladdMember
            // 
            this.lbladdMember.AutoSize = true;
            this.lbladdMember.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdMember.Location = new System.Drawing.Point(142, 124);
            this.lbladdMember.Name = "lbladdMember";
            this.lbladdMember.Size = new System.Drawing.Size(186, 22);
            this.lbladdMember.TabIndex = 1;
            this.lbladdMember.Text = "Ajouter un membre :";
            // 
            // txtAddMember
            // 
            this.txtAddMember.Location = new System.Drawing.Point(379, 126);
            this.txtAddMember.Name = "txtAddMember";
            this.txtAddMember.Size = new System.Drawing.Size(164, 20);
            this.txtAddMember.TabIndex = 2;
            this.txtAddMember.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddMember_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(562, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstMembers
            // 
            this.lstMembers.Location = new System.Drawing.Point(71, 177);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(161, 269);
            this.lstMembers.TabIndex = 4;
            this.lstMembers.UseCompatibleStateImageBehavior = false;
            this.lstMembers.View = System.Windows.Forms.View.List;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(71, 483);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(161, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Générer";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnDeleteName
            // 
            this.btnDeleteName.Location = new System.Drawing.Point(71, 454);
            this.btnDeleteName.Name = "btnDeleteName";
            this.btnDeleteName.Size = new System.Drawing.Size(161, 23);
            this.btnDeleteName.TabIndex = 6;
            this.btnDeleteName.Text = "Supprimer les noms";
            this.btnDeleteName.UseVisualStyleBackColor = true;
            this.btnDeleteName.Click += new System.EventHandler(this.btnDeleteName_Click);
            // 
            // lstTeamOne
            // 
            this.lstTeamOne.Location = new System.Drawing.Point(307, 239);
            this.lstTeamOne.Name = "lstTeamOne";
            this.lstTeamOne.Size = new System.Drawing.Size(191, 207);
            this.lstTeamOne.TabIndex = 7;
            this.lstTeamOne.UseCompatibleStateImageBehavior = false;
            this.lstTeamOne.View = System.Windows.Forms.View.List;
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOne.Location = new System.Drawing.Point(326, 203);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(151, 22);
            this.lblTeamOne.TabIndex = 8;
            this.lblTeamOne.Text = "Première équipe";
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwo.Location = new System.Drawing.Point(581, 203);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(159, 22);
            this.lblTeamTwo.TabIndex = 9;
            this.lblTeamTwo.Text = "Deuxième équipe";
            // 
            // lstTeamTwo
            // 
            this.lstTeamTwo.Location = new System.Drawing.Point(562, 239);
            this.lstTeamTwo.Name = "lstTeamTwo";
            this.lstTeamTwo.Size = new System.Drawing.Size(194, 207);
            this.lstTeamTwo.TabIndex = 10;
            this.lstTeamTwo.UseCompatibleStateImageBehavior = false;
            this.lstTeamTwo.View = System.Windows.Forms.View.List;
            // 
            // btnTeamReset
            // 
            this.btnTeamReset.Location = new System.Drawing.Point(446, 483);
            this.btnTeamReset.Name = "btnTeamReset";
            this.btnTeamReset.Size = new System.Drawing.Size(191, 23);
            this.btnTeamReset.TabIndex = 11;
            this.btnTeamReset.Text = "Ré-initialiser les équipes";
            this.btnTeamReset.UseVisualStyleBackColor = true;
            this.btnTeamReset.Click += new System.EventHandler(this.btnTeamReset_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(217, 550);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(362, 44);
            this.btnScore.TabIndex = 12;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TeamGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 606);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnTeamReset);
            this.Controls.Add(this.lstTeamTwo);
            this.Controls.Add(this.lblTeamTwo);
            this.Controls.Add(this.lblTeamOne);
            this.Controls.Add(this.lstTeamOne);
            this.Controls.Add(this.btnDeleteName);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddMember);
            this.Controls.Add(this.lbladdMember);
            this.Controls.Add(this.lblTitle);
            this.Name = "TeamGenerator";
            this.Text = "Team Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbladdMember;
        private System.Windows.Forms.TextBox txtAddMember;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstMembers;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDeleteName;
        private System.Windows.Forms.ListView lstTeamOne;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.Label lblTeamTwo;
        private System.Windows.Forms.ListView lstTeamTwo;
        private System.Windows.Forms.Button btnTeamReset;
        private System.Windows.Forms.Button btnScore;
    }
}

