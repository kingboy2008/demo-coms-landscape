using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using Smobiler.Core;
namespace COMSSmobilerDemo.Leave
{
    public partial class frmLeaveGrid : Smobiler.Core.MobileForm
    {

        #region "SmobilerForm Designer generated code "

        public frmLeaveGrid()
            : base()
        {

            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call

        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem1 = new Smobiler.Core.Controls.TextTabBarItem();
            Smobiler.Core.Controls.TextTabBarItem textTabBarItem2 = new Smobiler.Core.Controls.TextTabBarItem();
            this.GridView1 = new Smobiler.Core.Controls.GridView();
            this.addnew = new Smobiler.Core.Controls.ToolbarItem();
            this.TextTabBar1 = new Smobiler.Core.Controls.TextTabBar();
            // 
            // GridView1
            // 
            this.GridView1.AllowSlip = true;
            this.GridView1.Layout = "frmLeaveGrid_Layout";
            this.GridView1.Location = new System.Drawing.Point(0, 58);
            this.GridView1.Name = "GridView1";
            this.GridView1.ShowGridLines = false;
            this.GridView1.Size = new System.Drawing.Size(500, 172);
            this.GridView1.TabIndex = 4;
            this.GridView1.CellClick += new Smobiler.Core.Controls.GridViewCellClickEventHandler(this.GridView1_CellClick);
            this.GridView1.UpSlippling += new System.EventHandler(this.GridView1_UpSlippling);
            this.GridView1.DownSlippling += new System.EventHandler(this.GridView1_DownSlippling);
            // 
            // addnew
            // 
            this.addnew.IconID = "!\\ue148043146223";
            this.addnew.Name = "addnew";
            this.addnew.SelectIconID = "!\\ue148043146223";
            this.addnew.Text = "新增";
            // 
            // TextTabBar1
            // 
            this.TextTabBar1.BackColor = System.Drawing.Color.White;
            this.TextTabBar1.Border = new Smobiler.Core.Border(1);
            this.TextTabBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.BorderRadius = 2;
            this.TextTabBar1.BorderSize = 0.2F;
            this.TextTabBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            textTabBarItem1.Text = "我创建的";
            textTabBarItem1.Value = "LCreate";
            textTabBarItem2.Text = "我审批的";
            textTabBarItem2.Value = "LCheck";
            this.TextTabBar1.Items.AddRange(new Smobiler.Core.Controls.TextTabBarItem[] {
            textTabBarItem1,
            textTabBarItem2});
            this.TextTabBar1.Location = new System.Drawing.Point(25, 13);
            this.TextTabBar1.Name = "TextTabBar1";
            this.TextTabBar1.SelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.TextTabBar1.SelectForeColor = System.Drawing.Color.White;
            this.TextTabBar1.Size = new System.Drawing.Size(450, 35);
            this.TextTabBar1.TabIndex = 8;
            this.TextTabBar1.ItemClick += new Smobiler.Core.Controls.TabBarItemClickEventHandler(this.TextTabBar1_ItemClick);
            // 
            // frmLeaveGrid
            // 
            this.AllowSlip = true;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.GridView1,
            this.TextTabBar1});
            this.ScreenOrientation = Smobiler.Core.ScreenOrientation.Landscape;
            this.Size = new System.Drawing.Size(500, 230);
            this.StatusBarStyle = Smobiler.Core.StatusBarStyle.Default;
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("Exit", System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))));
            this.TitleText = "请假";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.addnew});
            this.ToolbarStyle = new Smobiler.Core.ToolBarSytle(Smobiler.Core.ToolbarSelectStyle.None, System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))), System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))), System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223))))));
            this.Load += new System.EventHandler(this.frmLeaveGrid_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.frmLeaveGrid_ToolbarItemClick);
            this.LeftSlipping += new System.EventHandler(this.frmLeaveGrid_LeftSlipping);
            this.RightSlipping += new System.EventHandler(this.frmLeaveGrid_RightSlipping);
            this.TitleImageClick += new System.EventHandler(this.MobileForm_TitleImageClick);
            this.KeyDown += new Smobiler.Core.KeyDownEventHandler(this.MobileForm_KeyDown);
            this.Name = "frmLeaveGrid";

        }
        internal Smobiler.Core.Controls.GridView GridView1;
        internal Smobiler.Core.Controls.ToolbarItem addnew;
        internal Smobiler.Core.Controls.TextTabBar TextTabBar1;
        #endregion

    }
}
