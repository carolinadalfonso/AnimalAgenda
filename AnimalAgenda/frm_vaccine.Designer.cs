namespace AnimalAgenda
{
    partial class frm_vaccine
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.lblVaccineDate = new DevExpress.XtraEditors.LabelControl();
            this.lblNameVaccine = new DevExpress.XtraEditors.LabelControl();
            this.dteVaccine = new DevExpress.XtraEditors.DateEdit();
            this.txtNameVaccine = new DevExpress.XtraEditors.TextEdit();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dteVaccine.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteVaccine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameVaccine.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVaccineDate
            // 
            this.lblVaccineDate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVaccineDate.Appearance.Options.UseFont = true;
            this.lblVaccineDate.Location = new System.Drawing.Point(26, 53);
            this.lblVaccineDate.Name = "lblVaccineDate";
            this.lblVaccineDate.Size = new System.Drawing.Size(113, 13);
            this.lblVaccineDate.TabIndex = 3;
            this.lblVaccineDate.Text = "Fecha de Aplicación:";
            // 
            // lblNameVaccine
            // 
            this.lblNameVaccine.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNameVaccine.Appearance.Options.UseFont = true;
            this.lblNameVaccine.Location = new System.Drawing.Point(26, 27);
            this.lblNameVaccine.Name = "lblNameVaccine";
            this.lblNameVaccine.Size = new System.Drawing.Size(108, 13);
            this.lblNameVaccine.TabIndex = 1;
            this.lblNameVaccine.Text = "Nombre de Vacuna:";
            // 
            // dteVaccine
            // 
            this.dteVaccine.EditValue = null;
            this.dteVaccine.Location = new System.Drawing.Point(153, 50);
            this.dteVaccine.Name = "dteVaccine";
            this.dteVaccine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteVaccine.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteVaccine.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dteVaccine.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dteVaccine.Size = new System.Drawing.Size(179, 20);
            this.dteVaccine.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "La fecha de aplicación es obligatoria.";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.validationProvider.SetValidationRule(this.dteVaccine, conditionValidationRule1);
            // 
            // txtNameVaccine
            // 
            this.txtNameVaccine.Location = new System.Drawing.Point(153, 24);
            this.txtNameVaccine.Name = "txtNameVaccine";
            this.txtNameVaccine.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtNameVaccine.Properties.MaxLength = 100;
            this.txtNameVaccine.Size = new System.Drawing.Size(179, 20);
            this.txtNameVaccine.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "El nombre de la vacuna es obligatorio.";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.validationProvider.SetValidationRule(this.txtNameVaccine, conditionValidationRule2);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdSave.Appearance.Options.UseBackColor = true;
            this.cmdSave.Location = new System.Drawing.Point(141, 9);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(115, 33);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Guardar";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.cmdCancel.Appearance.Options.UseBackColor = true;
            this.cmdCancel.CausesValidation = false;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(262, 9);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(87, 33);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Size = new System.Drawing.Size(361, 52);
            this.panel1.TabIndex = 26;
            // 
            // validationProvider
            // 
            this.validationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // frm_vaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 149);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dteVaccine);
            this.Controls.Add(this.lblVaccineDate);
            this.Controls.Add(this.txtNameVaccine);
            this.Controls.Add(this.lblNameVaccine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_vaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_vaccine";
            this.Load += new System.EventHandler(this.frm_vaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dteVaccine.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteVaccine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameVaccine.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dteVaccine;
        private DevExpress.XtraEditors.LabelControl lblVaccineDate;
        private DevExpress.XtraEditors.TextEdit txtNameVaccine;
        private DevExpress.XtraEditors.LabelControl lblNameVaccine;
        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
    }
}