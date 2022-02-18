
namespace AnimalAgenda
{
  partial class frm_main
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
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.gcAnimals = new DevExpress.XtraGrid.GridControl();
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.gvAnimals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Especie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Raza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tamaño = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuUsers = new DevExpress.XtraBars.BarSubItem();
            this.cmdCreateUsers = new DevExpress.XtraBars.BarButtonItem();
            this.cmdChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cmdSearch = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cmdAbout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cmdAdd = new DevExpress.XtraBars.BarButtonItem();
            this.cmdEdit = new DevExpress.XtraBars.BarButtonItem();
            this.cmdDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cmdExit = new DevExpress.XtraBars.BarButtonItem();
            this.rcMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.cmdMenu = new DevExpress.XtraBars.BarButtonItem();
            this.cmdCreateUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAnimals
            // 
            this.gcAnimals.DataSource = this.jsonDataSource1;
            this.gcAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAnimals.Location = new System.Drawing.Point(0, 104);
            this.gcAnimals.MainView = this.gvAnimals;
            this.gcAnimals.Name = "gcAnimals";
            this.gcAnimals.Size = new System.Drawing.Size(800, 346);
            this.gcAnimals.TabIndex = 0;
            this.gcAnimals.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnimals});
            // 
            // jsonDataSource1
            // 
            this.jsonDataSource1.Name = "jsonDataSource1";
            // 
            // gvAnimals
            // 
            this.gvAnimals.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nombre,
            this.Birthday,
            this.Especie,
            this.Raza,
            this.Sexo,
            this.Tamaño});
            this.gvAnimals.GridControl = this.gcAnimals;
            this.gvAnimals.Name = "gvAnimals";
            this.gvAnimals.OptionsBehavior.Editable = false;
            this.gvAnimals.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gvAnimals.OptionsBehavior.ReadOnly = true;
            this.gvAnimals.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvAnimals.OptionsMenu.EnableColumnMenu = false;
            this.gvAnimals.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvAnimals.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvAnimals.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAnimals_RowClick);
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Name";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 2;
            // 
            // Birthday
            // 
            this.Birthday.Caption = "F. Nacimiento";
            this.Birthday.FieldName = "Birthday";
            this.Birthday.Name = "Birthday";
            this.Birthday.UnboundDataType = typeof(System.DateTime);
            this.Birthday.Visible = true;
            this.Birthday.VisibleIndex = 3;
            // 
            // Especie
            // 
            this.Especie.Caption = "Especie";
            this.Especie.FieldName = "Species";
            this.Especie.Name = "Especie";
            this.Especie.Visible = true;
            this.Especie.VisibleIndex = 0;
            // 
            // Raza
            // 
            this.Raza.Caption = "Raza";
            this.Raza.FieldName = "Breed";
            this.Raza.Name = "Raza";
            this.Raza.Visible = true;
            this.Raza.VisibleIndex = 1;
            // 
            // Sexo
            // 
            this.Sexo.Caption = "Sexo";
            this.Sexo.FieldName = "Sex";
            this.Sexo.Name = "Sexo";
            this.Sexo.Visible = true;
            this.Sexo.VisibleIndex = 4;
            // 
            // Tamaño
            // 
            this.Tamaño.Caption = "Tamaño";
            this.Tamaño.FieldName = "Size";
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Visible = true;
            this.Tamaño.VisibleIndex = 5;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation1.GroupName = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.LargeButtons;
            this.ribbonPage2.ReduceOperations.Add(reduceOperation1);
            this.ribbonPage2.Text = "Perros";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.menuUsers);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // menuUsers
            // 
            this.menuUsers.Caption = "Usuarios";
            this.menuUsers.Id = 16;
            this.menuUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuUsers.ImageOptions.Image")));
            this.menuUsers.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdCreateUsers),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmdChangePassword)});
            this.menuUsers.Name = "menuUsers";
            this.menuUsers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // cmdCreateUsers
            // 
            this.cmdCreateUsers.Caption = "Crear Usuario";
            this.cmdCreateUsers.Id = 17;
            this.cmdCreateUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCreateUsers.ImageOptions.Image")));
            this.cmdCreateUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmdCreateUsers.ImageOptions.LargeImage")));
            this.cmdCreateUsers.Name = "cmdCreateUsers";
            this.cmdCreateUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdCreateUsers_ItemClick);
            // 
            // cmdChangePassword
            // 
            this.cmdChangePassword.Caption = "Cambiar Contraseña";
            this.cmdChangePassword.Id = 18;
            this.cmdChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdChangePassword.ImageOptions.Image")));
            this.cmdChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmdChangePassword.ImageOptions.LargeImage")));
            this.cmdChangePassword.Name = "cmdChangePassword";
            this.cmdChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdChangePassword_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.cmdSearch);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Caption = "Buscar";
            this.cmdSearch.Id = 8;
            this.cmdSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdSearch.ImageOptions.Image")));
            this.cmdSearch.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmdSearch.ImageOptions.LargeImage")));
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdSearch_ItemClick);
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup5.ItemLinks.Add(this.cmdAbout);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // cmdAbout
            // 
            this.cmdAbout.Caption = "Acerca de";
            this.cmdAbout.Id = 21;
            this.cmdAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAbout.ImageOptions.Image")));
            this.cmdAbout.LargeWidth = 60;
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.cmdAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdAbout_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.cmdAdd);
            this.ribbonPageGroup2.ItemLinks.Add(this.cmdEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.cmdDelete);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Caption = "Agregar";
            this.cmdAdd.Id = 5;
            this.cmdAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdd.ImageOptions.Image")));
            this.cmdAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmdAdd.ImageOptions.LargeImage")));
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.cmdAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdAdd_ItemClick);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Caption = "Modificar";
            this.cmdEdit.Id = 6;
            this.cmdEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdEdit.ImageOptions.Image")));
            this.cmdEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmdEdit.ImageOptions.LargeImage")));
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdEdit_ItemClick);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Caption = "Borrar";
            this.cmdDelete.Id = 7;
            this.cmdDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDelete.ImageOptions.Image")));
            this.cmdDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmdDelete.ImageOptions.LargeImage")));
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdDelete_ItemClick);
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup6.ItemLinks.Add(this.cmdExit);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // cmdExit
            // 
            this.cmdExit.Caption = "Salir";
            this.cmdExit.Id = 10;
            this.cmdExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdExit.ImageOptions.Image")));
            this.cmdExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("cmdExit.ImageOptions.LargeImage")));
            this.cmdExit.LargeWidth = 50;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.SmallWithTextWidth = 90;
            this.cmdExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmdExit_ItemClick);
            // 
            // rcMain
            // 
            this.rcMain.AllowMinimizeRibbon = false;
            this.rcMain.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.rcMain.AutoSizeItems = true;
            this.rcMain.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center;
            this.rcMain.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.rcMain.EmptyAreaImageOptions.Image = global::AnimalAgenda.Properties.Resources.logo;
            this.rcMain.EmptyAreaImageOptions.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rcMain.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(10);
            this.rcMain.EmptyAreaImageOptions.SizeMode = DevExpress.XtraBars.Ribbon.ViewInfo.RibbonEmptyAreaImageSizeMode.Zoom;
            this.rcMain.ExpandCollapseItem.Id = 0;
            this.rcMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rcMain.ExpandCollapseItem,
            this.rcMain.SearchEditItem,
            this.barButtonItem2,
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDelete,
            this.cmdSearch,
            this.cmdExit,
            this.cmdMenu,
            this.cmdCreateUser,
            this.barButtonItem3,
            this.menuUsers,
            this.cmdCreateUsers,
            this.cmdChangePassword,
            this.cmdAbout});
            this.rcMain.Location = new System.Drawing.Point(0, 0);
            this.rcMain.MaxItemId = 22;
            this.rcMain.Name = "rcMain";
            this.rcMain.OptionsPageCategories.ShowCaptions = false;
            this.rcMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.rcMain.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.rcMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcMain.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcMain.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcMain.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.rcMain.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.rcMain.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.rcMain.Size = new System.Drawing.Size(800, 104);
            this.rcMain.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.barButtonItem2);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.rcMain;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // cmdMenu
            // 
            this.cmdMenu.Caption = "barButtonItem1";
            this.cmdMenu.Id = 12;
            this.cmdMenu.Name = "cmdMenu";
            // 
            // cmdCreateUser
            // 
            this.cmdCreateUser.Caption = "Crear Usuario";
            this.cmdCreateUser.Id = 14;
            this.cmdCreateUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdCreateUser.ImageOptions.Image")));
            this.cmdCreateUser.Name = "cmdCreateUser";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cambiar Contraseña";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcAnimals);
            this.Controls.Add(this.rcMain);
            this.IconOptions.Image = global::AnimalAgenda.Properties.Resources.favicon;
            this.MinimumSize = new System.Drawing.Size(810, 455);
            this.Name = "frm_main";
            this.Ribbon = this.rcMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.gcAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gcAnimals;
    private DevExpress.XtraGrid.Views.Grid.GridView gvAnimals;
    private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
    private DevExpress.XtraGrid.Columns.GridColumn Birthday;
    private DevExpress.XtraGrid.Columns.GridColumn Nombre;
    private DevExpress.XtraGrid.Columns.GridColumn Especie;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonControl rcMain;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem cmdAdd;
        private DevExpress.XtraBars.BarButtonItem cmdEdit;
        private DevExpress.XtraBars.BarButtonItem cmdDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem cmdSearch;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem cmdExit;
        private DevExpress.XtraGrid.Columns.GridColumn Raza;
        private DevExpress.XtraGrid.Columns.GridColumn Sexo;
        private DevExpress.XtraGrid.Columns.GridColumn Tamaño;
        private DevExpress.XtraBars.BarSubItem menuUsers;
        private DevExpress.XtraBars.BarButtonItem cmdCreateUsers;
        private DevExpress.XtraBars.BarButtonItem cmdChangePassword;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem cmdMenu;
        private DevExpress.XtraBars.BarButtonItem cmdCreateUser;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem cmdAbout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

