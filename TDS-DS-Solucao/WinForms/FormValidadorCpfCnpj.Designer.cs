namespace WinForms
{
    partial class FormValidadorCpfCnpj
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTypeDocument = new System.Windows.Forms.Label();
            this.labelTypeDoc = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe um CPF ou CNPJ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelTypeDocument
            // 
            this.labelTypeDocument.AutoSize = true;
            this.labelTypeDocument.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeDocument.Location = new System.Drawing.Point(21, 80);
            this.labelTypeDocument.Name = "labelTypeDocument";
            this.labelTypeDocument.Size = new System.Drawing.Size(117, 16);
            this.labelTypeDocument.TabIndex = 2;
            this.labelTypeDocument.Text = "Tipo do documento";
            // 
            // labelTypeDoc
            // 
            this.labelTypeDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTypeDoc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeDoc.Location = new System.Drawing.Point(24, 102);
            this.labelTypeDoc.Name = "labelTypeDoc";
            this.labelTypeDoc.Size = new System.Drawing.Size(153, 20);
            this.labelTypeDoc.TabIndex = 3;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(21, 145);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(45, 16);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.on_Click);
            // 
            // FormValidadorCpfCnpj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTypeDoc);
            this.Controls.Add(this.labelTypeDocument);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormValidadorCpfCnpj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTypeDocument;
        private System.Windows.Forms.Label labelTypeDoc;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}