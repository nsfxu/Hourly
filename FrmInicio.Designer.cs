namespace Hourly
{
    partial class frm_home
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
            this.ltx_result = new System.Windows.Forms.ListBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.dtp_entrada = new System.Windows.Forms.DateTimePicker();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_almoco = new System.Windows.Forms.DateTimePicker();
            this.gpx_info = new System.Windows.Forms.GroupBox();
            this.dtp_carga_horaria = new System.Windows.Forms.DateTimePicker();
            this.lbl_carga = new System.Windows.Forms.Label();
            this.gpx_calc = new System.Windows.Forms.GroupBox();
            this.ltx_calc = new System.Windows.Forms.ListBox();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gpx_info.SuspendLayout();
            this.gpx_calc.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltx_result
            // 
            this.ltx_result.FormattingEnabled = true;
            this.ltx_result.ItemHeight = 15;
            this.ltx_result.Location = new System.Drawing.Point(6, 193);
            this.ltx_result.Name = "ltx_result";
            this.ltx_result.Size = new System.Drawing.Size(372, 109);
            this.ltx_result.TabIndex = 0;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(30, 124);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(313, 52);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Gerar";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // dtp_entrada
            // 
            this.dtp_entrada.CustomFormat = "HH:mm";
            this.dtp_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_entrada.Location = new System.Drawing.Point(226, 28);
            this.dtp_entrada.Name = "dtp_entrada";
            this.dtp_entrada.ShowUpDown = true;
            this.dtp_entrada.Size = new System.Drawing.Size(117, 23);
            this.dtp_entrada.TabIndex = 3;
            this.dtp_entrada.Value = new System.DateTime(2022, 10, 10, 8, 0, 0, 0);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_inicio.Location = new System.Drawing.Point(6, 28);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(148, 20);
            this.lbl_inicio.TabIndex = 4;
            this.lbl_inicio.Text = "Início do expediente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duração do horário de almoço:";
            // 
            // dtp_almoco
            // 
            this.dtp_almoco.CustomFormat = "HH:mm";
            this.dtp_almoco.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_almoco.Location = new System.Drawing.Point(226, 80);
            this.dtp_almoco.Name = "dtp_almoco";
            this.dtp_almoco.ShowUpDown = true;
            this.dtp_almoco.Size = new System.Drawing.Size(117, 23);
            this.dtp_almoco.TabIndex = 6;
            this.dtp_almoco.Value = new System.DateTime(2022, 10, 10, 1, 0, 0, 0);
            // 
            // gpx_info
            // 
            this.gpx_info.Controls.Add(this.dtp_carga_horaria);
            this.gpx_info.Controls.Add(this.lbl_carga);
            this.gpx_info.Controls.Add(this.ltx_result);
            this.gpx_info.Controls.Add(this.btn_calcular);
            this.gpx_info.Controls.Add(this.dtp_almoco);
            this.gpx_info.Controls.Add(this.dtp_entrada);
            this.gpx_info.Controls.Add(this.label1);
            this.gpx_info.Controls.Add(this.lbl_inicio);
            this.gpx_info.Location = new System.Drawing.Point(12, 12);
            this.gpx_info.Name = "gpx_info";
            this.gpx_info.Size = new System.Drawing.Size(384, 323);
            this.gpx_info.TabIndex = 7;
            this.gpx_info.TabStop = false;
            this.gpx_info.Text = "Informações";
            // 
            // dtp_carga_horaria
            // 
            this.dtp_carga_horaria.CustomFormat = "HH:mm";
            this.dtp_carga_horaria.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_carga_horaria.Location = new System.Drawing.Point(226, 54);
            this.dtp_carga_horaria.Name = "dtp_carga_horaria";
            this.dtp_carga_horaria.ShowUpDown = true;
            this.dtp_carga_horaria.Size = new System.Drawing.Size(117, 23);
            this.dtp_carga_horaria.TabIndex = 9;
            this.dtp_carga_horaria.Value = new System.DateTime(2022, 10, 10, 8, 0, 0, 0);
            // 
            // lbl_carga
            // 
            this.lbl_carga.AutoSize = true;
            this.lbl_carga.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_carga.Location = new System.Drawing.Point(6, 54);
            this.lbl_carga.Name = "lbl_carga";
            this.lbl_carga.Size = new System.Drawing.Size(102, 20);
            this.lbl_carga.TabIndex = 8;
            this.lbl_carga.Text = "Carga horária:";
            // 
            // gpx_calc
            // 
            this.gpx_calc.Controls.Add(this.ltx_calc);
            this.gpx_calc.Controls.Add(this.dtp_fim);
            this.gpx_calc.Controls.Add(this.label2);
            this.gpx_calc.Controls.Add(this.btn_calc);
            this.gpx_calc.Controls.Add(this.dtp_inicio);
            this.gpx_calc.Controls.Add(this.label4);
            this.gpx_calc.Location = new System.Drawing.Point(411, 12);
            this.gpx_calc.Name = "gpx_calc";
            this.gpx_calc.Size = new System.Drawing.Size(244, 323);
            this.gpx_calc.TabIndex = 10;
            this.gpx_calc.TabStop = false;
            this.gpx_calc.Text = "Calculo de diferença de horas";
            // 
            // ltx_calc
            // 
            this.ltx_calc.FormattingEnabled = true;
            this.ltx_calc.ItemHeight = 15;
            this.ltx_calc.Location = new System.Drawing.Point(18, 164);
            this.ltx_calc.Name = "ltx_calc";
            this.ltx_calc.Size = new System.Drawing.Size(210, 139);
            this.ltx_calc.TabIndex = 10;
            // 
            // dtp_fim
            // 
            this.dtp_fim.CustomFormat = "HH:mm";
            this.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fim.Location = new System.Drawing.Point(100, 63);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.ShowUpDown = true;
            this.dtp_fim.Size = new System.Drawing.Size(117, 23);
            this.dtp_fim.TabIndex = 9;
            this.dtp_fim.Value = new System.DateTime(2022, 10, 10, 8, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fim:";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(35, 97);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(172, 52);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CustomFormat = "HH:mm";
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(100, 28);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.ShowUpDown = true;
            this.dtp_inicio.Size = new System.Drawing.Size(117, 23);
            this.dtp_inicio.TabIndex = 3;
            this.dtp_inicio.Value = new System.DateTime(2022, 10, 10, 8, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Início:";
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 347);
            this.Controls.Add(this.gpx_calc);
            this.Controls.Add(this.gpx_info);
            this.Name = "frm_home";
            this.Text = "Home";
            this.gpx_info.ResumeLayout(false);
            this.gpx_info.PerformLayout();
            this.gpx_calc.ResumeLayout(false);
            this.gpx_calc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox ltx_result;
        private Button btn_calcular;
        private DateTimePicker dtp_entrada;
        private Label lbl_inicio;
        private Label label1;
        private DateTimePicker dtp_almoco;
        private GroupBox gpx_info;
        private DateTimePicker dtp_carga_horaria;
        private Label lbl_carga;
        private GroupBox gpx_calc;
        private ListBox ltx_calc;
        private DateTimePicker dtp_fim;
        private Label label2;
        private Button btn_calc;
        private DateTimePicker dtp_inicio;
        private Label label4;
    }
}