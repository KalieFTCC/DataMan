namespace Dataman
{
    partial class AnswerMan
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
            this.scoreLbl = new System.Windows.Forms.Label();
            this.NumberLblA = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.SymbolLblA = new System.Windows.Forms.Label();
            this.NumberLblB = new System.Windows.Forms.Label();
            this.EqualsLbl = new System.Windows.Forms.Label();
            this.answerTxT = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.ForeColor = System.Drawing.Color.Crimson;
            this.scoreLbl.Location = new System.Drawing.Point(12, 9);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(47, 13);
            this.scoreLbl.TabIndex = 0;
            this.scoreLbl.Text = "Score: 0";
            // 
            // NumberLblA
            // 
            this.NumberLblA.AutoSize = true;
            this.NumberLblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLblA.Location = new System.Drawing.Point(106, 47);
            this.NumberLblA.Name = "NumberLblA";
            this.NumberLblA.Size = new System.Drawing.Size(47, 33);
            this.NumberLblA.TabIndex = 1;
            this.NumberLblA.Text = "00";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLbl.ForeColor = System.Drawing.Color.SeaGreen;
            this.answerLbl.Location = new System.Drawing.Point(12, 98);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(61, 20);
            this.answerLbl.TabIndex = 2;
            this.answerLbl.Text = "Correct";
            // 
            // SymbolLblA
            // 
            this.SymbolLblA.AutoSize = true;
            this.SymbolLblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolLblA.Location = new System.Drawing.Point(185, 47);
            this.SymbolLblA.Name = "SymbolLblA";
            this.SymbolLblA.Size = new System.Drawing.Size(32, 33);
            this.SymbolLblA.TabIndex = 3;
            this.SymbolLblA.Text = "+";
            // 
            // NumberLblB
            // 
            this.NumberLblB.AutoSize = true;
            this.NumberLblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLblB.Location = new System.Drawing.Point(245, 47);
            this.NumberLblB.Name = "NumberLblB";
            this.NumberLblB.Size = new System.Drawing.Size(47, 33);
            this.NumberLblB.TabIndex = 4;
            this.NumberLblB.Text = "00";
            // 
            // EqualsLbl
            // 
            this.EqualsLbl.AutoSize = true;
            this.EqualsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsLbl.Location = new System.Drawing.Point(327, 47);
            this.EqualsLbl.Name = "EqualsLbl";
            this.EqualsLbl.Size = new System.Drawing.Size(32, 33);
            this.EqualsLbl.TabIndex = 5;
            this.EqualsLbl.Text = "=";
            // 
            // answerTxT
            // 
            this.answerTxT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTxT.Location = new System.Drawing.Point(398, 40);
            this.answerTxT.Name = "answerTxT";
            this.answerTxT.Size = new System.Drawing.Size(62, 40);
            this.answerTxT.TabIndex = 6;
            this.answerTxT.TextChanged += new System.EventHandler(this.CheckAnswer);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(498, 40);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(86, 40);
            this.CheckButton.TabIndex = 7;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckBtnClick);
            // 
            // AnswerMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 218);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.answerTxT);
            this.Controls.Add(this.EqualsLbl);
            this.Controls.Add(this.NumberLblB);
            this.Controls.Add(this.SymbolLblA);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.NumberLblA);
            this.Controls.Add(this.scoreLbl);
            this.Name = "AnswerMan";
            this.Text = "AnswerMan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label NumberLblA;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.Label SymbolLblA;
        private System.Windows.Forms.Label NumberLblB;
        private System.Windows.Forms.Label EqualsLbl;
        private System.Windows.Forms.TextBox answerTxT;
        private System.Windows.Forms.Button CheckButton;
    }
}

