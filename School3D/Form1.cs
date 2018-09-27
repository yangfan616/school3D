using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.GlobeCore;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Analyst3D;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Animation;


namespace School3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 创建
        /// </summary>
        private IGlobe m_Globe = null;
        private IGlobeDisplay m_GlobeDisplay = null;
        private IGlobeViewUtil m_GlobeViewUtil = null;
        /// <summary>
        /// 创建IEnvelope对象，用于在鹰眼模式中查找在矩形框内的map内容
        /// </summary>
        private IEnvelope m_MapExtent = null;
        private ISceneViewer m_SceneView = null;
        ISceneBookmarks m_SceneBookmarks = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            m_Globe = axGlobeControl1.Globe;
            m_GlobeDisplay = m_Globe.GlobeDisplay;
            m_SceneView = m_GlobeDisplay.ActiveViewer;
            m_GlobeViewUtil = axGlobeControl1.GlobeCamera as IGlobeViewUtil;

            IGlobeDisplayEvents_Event m_GlobeDisplayEvents = axGlobeControl1.Globe.GlobeDisplay as IGlobeDisplayEvents_Event;
            //将三维视图重绘事件委托给m_GlobeDisplayEvents_AfterDraw方法
            m_GlobeDisplayEvents.AfterDraw += new IGlobeDisplayEvents_AfterDrawEventHandler(m_GlobeDisplayEvents_AfterDraw);
            
            axMapControl1.Extent = axMapControl1.FullExtent;
            comboBox1.SelectedIndex = 0;

        }

        /// <summary>
        /// 获得三维视图的显示范围，并在二维地图上显示
        /// </summary>
        /// <param name="pViewer"></param>
        void m_GlobeDisplayEvents_AfterDraw(ISceneViewer pViewer)
        {
            m_MapExtent = new EnvelopeClass();

            m_GlobeViewUtil.QueryVisibleGeographicExtent(m_MapExtent);
            
            IGraphicsContainer pGra = axMapControl1.Map as IGraphicsContainer;
            IActiveView pAv = pGra as IActiveView;
            pGra.DeleteAllElements();

            IRectangleElement rec = new RectangleElementClass();
            IElement ele = rec as IElement;
            ele.Geometry = m_MapExtent;
            //创建颜色对象
            IRgbColor pColor = new RgbColorClass();
            pColor.Red = 255;
            pColor.Green = 0;
            pColor.Blue = 0;
            //创建线型对象并设置颜色和宽度
            ILineSymbol line = new SimpleLineSymbolClass();
            line.Color = pColor;
            line.Width = 2;

            pColor = new RgbColorClass();
            pColor.Red = 255;
            pColor.Green = 0;
            pColor.Blue = 0;
            pColor.Transparency = 0;//设置透明度

            IFillSymbol fill = new SimpleFillSymbolClass();
            fill.Outline = line;
            fill.Color = pColor;

            IFillShapeElement pFillElement = ele as IFillShapeElement;
            pFillElement.Symbol = fill;



            pGra.AddElement((IElement)pFillElement, 0);

            pAv.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (axMapControl1.Map.LayerCount != 0)
            {
                if (e.button == 1)
                { return; }
                else if (e.button == 2)
                {
                    IEnvelope env = axMapControl1.TrackRectangle();
                    IZAware ZAware = env as IZAware;
                    ZAware.ZAware = true;
                    axGlobeControl1.GlobeCamera.SetToZoomToExtents(env, m_Globe, m_SceneView);
                    axGlobeControl1.GlobeDisplay.RefreshViewers();
                }
            }
        }

       
        
        
        //放大至图层方法
        private void ZoomToGlobeLayer(IGlobe globe, int layerindex)
        {
            IGlobeDisplay globeDisplay = globe.GlobeDisplay;
            ISceneViewer sceneViewer = globeDisplay.ActiveViewer;
            ICamera camera = sceneViewer.Camera;
            IGlobeCamera globeCamera = camera as IGlobeCamera;
            IScene scene = globe as IScene;
            ILayer layer = scene.get_Layer(layerindex);
            IEnvelope extent = layer.AreaOfInterest.Envelope;
            globeCamera.SetToZoomToExtents(extent, globe, sceneViewer);
        }



        /// <summary>
        /// 添加书签方法,使用bookmark3D接口和ISceneBookmarks接口
        /// </summary>
        /// <param name="bookmarkName">书签名称</param>
        /// <param name="camera">相机</param>
        /// <param name="scene">视图</param>
        /// <returns>返回一个场景图</returns>
        private ISceneBookmarks AddBookmark3DToSceneBookmarks(string bookmarkName, ICamera camera, IScene scene)
        {
            IBookmark3D bookmark3D = new Bookmark3DClass();
            bookmark3D.Name = bookmarkName;//获得书签名
            bookmark3D.Capture(camera);//捕获相机
            //创建ISceneBookmarks对象,并将摄影机当前位置添加到里面
            ISceneBookmarks sceneBookmarks = scene as ISceneBookmarks;
            sceneBookmarks.AddBookmark(bookmark3D);
            //返回当前场景
            return sceneBookmarks;
        }

        /// <summary>
        /// 使书签在listBox中显示方法
        /// </summary>
        /// <param name="sceneBookmarks"></param>
        private void ShowAllBookmarkNameToList(ISceneBookmarks sceneBookmarks)
        {
            //创建
            IArray bookmarkArray = sceneBookmarks.Bookmarks;
            for (int i = 0; i < bookmarkArray.Count; i++)
            {
                System.Object oo = bookmarkArray.get_Element(i);
                IBookmark3D bookmark = oo as IBookmark3D;
                //
                listBox1.Items.Add(bookmark.Name);
            }
        }
        /// <summary>
        /// 删除选中的书签
        /// </summary>
        /// <param name="sceneBookmarks"></param>
        /// <param name="bookmarkName"></param>
        private void RemoveBookmark(ISceneBookmarks sceneBookmarks, string bookmarkName)
        {
            IBookmark3D bookmark = new Bookmark3DClass();
            
            sceneBookmarks.FindBookmark(bookmarkName, out bookmark);
            sceneBookmarks.RemoveBookmark(bookmark);
            ShowAllBookmarkNameToList(sceneBookmarks);
        }
        //放大至书签
        private void ZoomToBookmark3D(string bookmarkName)
        {
            IBookmark3D bookmark = new Bookmark3DClass();
            m_SceneBookmarks.FindBookmark(bookmarkName, out bookmark);
            bookmark.Apply(m_SceneView, false, 0);
            m_SceneView.Redraw(true);
        }

        private void btnZoomToBookmark_Click(object sender, EventArgs e)
        {
            try
            {
                string name = listBox1.SelectedItem.ToString();
                ZoomToBookmark3D(name);
            }
            catch { }
        }

        private void btnZoomToGlobeLayer_Click(object sender, EventArgs e)
        {
            try
            {
                ZoomToGlobeLayer(m_Globe, comboBox1.SelectedIndex);
            }
            catch { }
        }

        private void btnAddBookmark_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("书签名字不能为空！！");
                    return;
                }
                listBox1.Items.Clear();
                string bookmarkName = textBox1.Text;
                IScene scene = m_Globe as IScene;
                ICamera camera = m_SceneView.Camera;
                m_SceneBookmarks = AddBookmark3DToSceneBookmarks(bookmarkName, camera, scene);
                //int i = m_SceneBookmarks.BookmarkCount;
                //MessageBox.Show(i.ToString());
                ShowAllBookmarkNameToList(m_SceneBookmarks);
                textBox1.Text = "";
            }
            catch { }
        }

        private void btnRemoveBookmark_Click(object sender, EventArgs e)
        {
            try
            {
                string name = listBox1.SelectedItem.ToString();
                listBox1.Items.Clear();
                RemoveBookmark(m_SceneBookmarks, name);
            }
            catch { }
        }

        private void btnClearBookmarks_Click(object sender, EventArgs e)
        {
            try
            {
                m_SceneBookmarks.RemoveAllBookmarks();
                listBox1.Items.Clear();
            }
            catch { }
        }
        
        
        /// <summary>
        /// 打开地图:实例化Icommand类，调用其中的打开global的方法，创建在axGlobalControl中
        /// AE内置了command和tool两种插件Command不需要用鼠标等与地图进行交互，直接使用OnCreate方法实现
        /// Tool则需要鼠标等与地图交互
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsGlobeOpenDocCommandClass();
            cmd.OnCreate(axGlobeControl1.Object);
            cmd.OnClick();
        }
        /// <summary>
        /// 地图全览：实例化Icommand类中的控制地图全览的方法，创建在axGlobalControl中，点击鼠标实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullExtent_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsGlobeFullExtentCommandClass();
            cmd.OnCreate(axGlobeControl1.Object);
            cmd.OnClick();
        }
        /// <summary>
        /// 地图导航：实例化Icommand类中的控制地图全览的方法，创建在axGlobalControl中，点击鼠标实现
        /// 并将axGlobalControl的currentTool属性设置为cmd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navigation_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsGlobeNavigateToolClass();
            cmd.OnCreate(axGlobeControl1.Object);
            cmd.OnClick();
            axGlobeControl1.CurrentTool = cmd as ITool;
        }
        /// <summary>
        /// 同上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navagationMode_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsGlobeNavigationModeCommandClass();
            cmd.OnCreate(axGlobeControl1.Object);
            cmd.OnClick();
        }
        /// <summary>
        /// 放大缩小：实例化Icommand类中的控制地图放缩的方法，创建在axGlobalControl中，点击鼠标实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inOut_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsGlobeZoomInOutToolClass();
            cmd.OnCreate(axGlobeControl1.Object);
            cmd.OnClick();
            axGlobeControl1.CurrentTool = cmd as ITool;
        }
        /// <summary>
        /// 信息概览：实例化Icommand类中的Identify方法，创建在axGlobalControl中，点击鼠标实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void identify_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsGlobeIdentifyToolClass();
            cmd.OnCreate(axGlobeControl1.Object);
            cmd.OnClick();
            axGlobeControl1.CurrentTool = cmd as ITool;
        }
        /// <summary>
        /// 测量工具,返回两点间的距离数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void measure_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsGlobeMeasureToolClass();
            cmd.OnCreate(axGlobeControl1.Object);
            cmd.OnClick();
            axGlobeControl1.CurrentTool = cmd as ITool;
        }
        /// <summary>
        /// 漫游功能：实现地图的移动查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pan_Click_1(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsGlobePanDragToolClass();
            cmd.OnCreate(axGlobeControl1.Object);
            cmd.OnClick();
            axGlobeControl1.CurrentTool = cmd as ITool;
        }







        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
        
        
        
        
        
        //进行查询
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                richTextBox1.Text = "";
                IScene scene = m_Globe as IScene;
                ILayer layer = scene.get_Layer(0);
                IFeatureLayer fl = layer as IFeatureLayer;
                IFeatureClass fc = fl.FeatureClass;
                IQueryFilter query = new QueryFilterClass();
                query.WhereClause = "Name = " + "'" + textBox2.Text + "'";
                IFeatureCursor featurecursor = fc.Search(query, false);
                IFeature feature = featurecursor.NextFeature();
                if (feature != null)
                {
                    string info = feature.get_Value(0).ToString() + "\n" + feature.get_Value(1).ToString() + "\n" + feature.get_Value(2).ToString();
                    richTextBox1.AppendText(info);
                    scene.SelectFeature(layer, feature);
                    m_SceneView.Redraw(true);
                }
            }
            catch { }
        }
        //清除查询结果
        private void button2_Click(object sender, EventArgs e)
        {
            IScene scene = m_Globe as IScene;
            scene.ClearSelection();
            m_SceneView.Redraw(true);
        }
        //将查询到的结果放大
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                IScene scene = m_Globe as IScene;
                IEnvelope envelop = new EnvelopeClass();
                envelop.SetEmpty();
                IEnvelope inEnvelope = new EnvelopeClass();
                inEnvelope.SetEmpty();
                IZAware zaware = envelop as IZAware;
                zaware.ZAware = true;
                ISpatialFilter sf = new SpatialFilterClass();
                ISpatialReference spr = scene.SpatialReference;

                ILayer layer = scene.get_Layer(0);
                IFeatureSelection featuresect = layer as IFeatureSelection;

                IFeatureLayer fl = layer as IFeatureLayer;
                IFeatureClass fc = fl.FeatureClass;
                ISelectionSet selectionset = featuresect.SelectionSet;
                string shapeField = fc.ShapeFieldName;
                sf.set_OutputSpatialReference(shapeField, spr);
                ICursor cursor;
                selectionset.Search(sf, true, out cursor);

                IFeatureCursor featureCursor = cursor as IFeatureCursor;
                IFeature feature;
                if ((feature = featureCursor.NextFeature()) != null)
                {
                    IGeometry geometry = feature.Shape;
                    inEnvelope = geometry.Envelope;
                    envelop.Union(inEnvelope);
                }
                IGlobeCamera globecamera = m_SceneView.Camera as IGlobeCamera;
                globecamera.SetToZoomToExtents(envelop, m_Globe, m_SceneView);
                m_SceneView.Redraw(true);
            }
            catch { }
        }

        private void axLicenseControl1_Enter(object sender, EventArgs e)
        {

        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            帮助 help = new 帮助();
            help.Show();
        }




    }
}