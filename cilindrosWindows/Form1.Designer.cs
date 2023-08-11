namespace cilindrosWindows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RadioText = new TextBox();
            AlturaText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CalcularBoton = new Button();
            label3 = new Label();
            LabelContador = new Label();
            SuspendLayout();
            // 
            // RadioText
            // 
            RadioText.Location = new Point(83, 61);
            RadioText.Name = "RadioText";
            RadioText.Size = new Size(100, 23);
            RadioText.TabIndex = 0;
            // 
            // AlturaText
            // 
            AlturaText.Location = new Point(83, 115);
            AlturaText.Name = "AlturaText";
            AlturaText.Size = new Size(100, 23);
            AlturaText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 43);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Altura";
            // 
            // CalcularBoton
            // 
            CalcularBoton.Location = new Point(231, 89);
            CalcularBoton.Name = "CalcularBoton";
            CalcularBoton.Size = new Size(75, 23);
            CalcularBoton.TabIndex = 4;
            CalcularBoton.Text = "Calcular";
            CalcularBoton.UseVisualStyleBackColor = true;
            CalcularBoton.Click += CalcularBoton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 184);
            label3.Name = "label3";
            label3.Size = new Size(182, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad de cilindros ingresados:";
            // 
            // LabelContador
            // 
            LabelContador.AutoSize = true;
            LabelContador.Location = new Point(227, 184);
            LabelContador.Name = "LabelContador";
            LabelContador.Size = new Size(13, 15);
            LabelContador.TabIndex = 6;
            LabelContador.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 237);
            Controls.Add(LabelContador);
            Controls.Add(label3);
            Controls.Add(CalcularBoton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AlturaText);
            Controls.Add(RadioText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RadioText;
        private TextBox AlturaText;
        private Label label1;
        private Label label2;
        private Button CalcularBoton;
        private Label label3;
        private Label LabelContador;
    }
}