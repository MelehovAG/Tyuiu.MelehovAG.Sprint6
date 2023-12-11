
namespace Tyuiu.MelehovAG.Sprint6.Task0.V11
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_SDA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SDA = new System.Windows.Forms.GroupBox();
            this.labelVarX_SDA = new System.Windows.Forms.Label();
            this.textBoxVarX_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SDA = new System.Windows.Forms.TextBox();
            this.labelResult_SDA = new System.Windows.Forms.Label();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.groupBoxTask_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).BeginInit();
            this.groupBoxInput_SDA.SuspendLayout();
            this.groupBoxOutput_SDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.pictureBoxFormula_SDA);
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(468, 118);
            this.groupBoxTask_SDA.TabIndex = 1;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // pictureBoxFormula_SDA
            // 
            this.pictureBoxFormula_SDA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SDA.Image")));
            this.pictureBoxFormula_SDA.Location = new System.Drawing.Point(212, 79);
            this.pictureBoxFormula_SDA.Name = "pictureBoxFormula_SDA";
            this.pictureBoxFormula_SDA.Size = new System.Drawing.Size(255, 39);
            this.pictureBoxFormula_SDA.TabIndex = 3;
            this.pictureBoxFormula_SDA.TabStop = false;
            this.pictureBoxFormula_SDA.Click += new System.EventHandler(this.pictureBoxFormula_SDA_Click);
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(19, 19);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(429, 45);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.Text = "Дано выражение на скриншоте. Требуется вычислить его значение при x = 2, результа" +
    "т вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфе" +
    "йс оформить по шаблону из лекции.";
            this.textBoxTask_SDA.TextChanged += new System.EventHandler(this.textBoxTask_SDA_TextChanged);
            // 
            // groupBoxInput_SDA
            // 
            this.groupBoxInput_SDA.Controls.Add(this.labelVarX_SDA);
            this.groupBoxInput_SDA.Controls.Add(this.textBoxVarX_SDA);
            this.groupBoxInput_SDA.Location = new System.Drawing.Point(12, 146);
            this.groupBoxInput_SDA.Name = "groupBoxInput_SDA";
            this.groupBoxInput_SDA.Size = new System.Drawing.Size(190, 87);
            this.groupBoxInput_SDA.TabIndex = 2;
            this.groupBoxInput_SDA.TabStop = false;
            this.groupBoxInput_SDA.Text = "Ввод данных";
            // 
            // labelVarX_SDA
            // 
            this.labelVarX_SDA.AutoSize = true;
            this.labelVarX_SDA.Location = new System.Drawing.Point(16, 30);
            this.labelVarX_SDA.Name = "labelVarX_SDA";
            this.labelVarX_SDA.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_SDA.TabIndex = 1;
            this.labelVarX_SDA.Text = "Переменная X:";
            // 
            // textBoxVarX_SDA
            // 
            this.textBoxVarX_SDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxVarX_SDA.Location = new System.Drawing.Point(19, 46);
            this.textBoxVarX_SDA.Name = "textBoxVarX_SDA";
            this.textBoxVarX_SDA.Size = new System.Drawing.Size(152, 20);
            this.textBoxVarX_SDA.TabIndex = 0;
            this.textBoxVarX_SDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_SDA_KeyPress);
            // 
            // groupBoxOutput_SDA
            // 
            this.groupBoxOutput_SDA.Controls.Add(this.textBoxResult_SDA);
            this.groupBoxOutput_SDA.Controls.Add(this.labelResult_SDA);
            this.groupBoxOutput_SDA.Location = new System.Drawing.Point(275, 146);
            this.groupBoxOutput_SDA.Name = "groupBoxOutput_SDA";
            this.groupBoxOutput_SDA.Size = new System.Drawing.Size(205, 87);
            this.groupBoxOutput_SDA.TabIndex = 3;
            this.groupBoxOutput_SDA.TabStop = false;
            this.groupBoxOutput_SDA.Text = "Вывод данных";
            // 
            // textBoxResult_SDA
            // 
            this.textBoxResult_SDA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxResult_SDA.Location = new System.Drawing.Point(26, 46);
            this.textBoxResult_SDA.Name = "textBoxResult_SDA";
            this.textBoxResult_SDA.ReadOnly = true;
            this.textBoxResult_SDA.Size = new System.Drawing.Size(159, 20);
            this.textBoxResult_SDA.TabIndex = 4;
            this.textBoxResult_SDA.TextChanged += new System.EventHandler(this.textBoxResult_SDA_TextChanged);
            // 
            // labelResult_SDA
            // 
            this.labelResult_SDA.AutoSize = true;
            this.labelResult_SDA.Location = new System.Drawing.Point(23, 30);
            this.labelResult_SDA.Name = "labelResult_SDA";
            this.labelResult_SDA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SDA.TabIndex = 3;
            this.labelResult_SDA.Text = "Результат:";
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_SDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SDA.Location = new System.Drawing.Point(276, 239);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(48, 40);
            this.buttonHelp_SDA.TabIndex = 5;
            this.buttonHelp_SDA.Text = "?";
            this.buttonHelp_SDA.UseVisualStyleBackColor = false;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDone_SDA.Location = new System.Drawing.Point(359, 239);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(122, 40);
            this.buttonDone_SDA.TabIndex = 6;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(491, 308);
            this.Controls.Add(this.buttonDone_SDA);
            this.Controls.Add(this.buttonHelp_SDA);
            this.Controls.Add(this.groupBoxOutput_SDA);
            this.Controls.Add(this.groupBoxInput_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 11 | Мелехов А.Г.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SDA)).EndInit();
            this.groupBoxInput_SDA.ResumeLayout(false);
            this.groupBoxInput_SDA.PerformLayout();
            this.groupBoxOutput_SDA.ResumeLayout(false);
            this.groupBoxOutput_SDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.GroupBox groupBoxInput_SDA;
        private System.Windows.Forms.Label labelVarX_SDA;
        private System.Windows.Forms.TextBox textBoxVarX_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutput_SDA;
        private System.Windows.Forms.TextBox textBoxResult_SDA;
        private System.Windows.Forms.Label labelResult_SDA;
        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
    }
}

