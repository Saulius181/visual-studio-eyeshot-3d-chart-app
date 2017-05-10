namespace WindowsFormsApplication1
{
    partial class Form1
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
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton2 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar2 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.CircularWin10, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton2, false);
            devDept.Graphics.BackgroundSettings backgroundSettings2 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.3D);
            devDept.Eyeshot.Camera camera2 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 50D), 600D, new devDept.Geometry.Quaternion(0.086824088833465166D, 0.15038373318043533D, 0.492403876506104D, 0.85286853195244339D), devDept.Graphics.projectionType.Perspective, 50D, 5.7700002687809251D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton2 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton2 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton2 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton2 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton2 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton2 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton2 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar2 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.VerticalMiddleRight, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton2))});
            devDept.Eyeshot.Grid grid2 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 5D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))), false, true, false, false, 10, 100, 5, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false);
            devDept.Eyeshot.RotateSettings rotateSettings2 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings2 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10);
            devDept.Eyeshot.PanSettings panSettings2 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings2 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager2 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport2 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(524, 577), backgroundSettings2, camera2, new devDept.Eyeshot.ToolBar[] {
            toolBar2}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid2}, false, rotateSettings2, zoomSettings2, panSettings2, navigationSettings2, savedViewsManager2, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon2 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol2 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon2 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Axis = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToleranceLower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToleranceUpper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invalid_measure_label = new System.Windows.Forms.Label();
            this.valid_measure_label = new System.Windows.Forms.Label();
            this.median_z_label_value = new System.Windows.Forms.Label();
            this.median_y_label_value = new System.Windows.Forms.Label();
            this.median_x_label_value = new System.Windows.Forms.Label();
            this.median_z_label = new System.Windows.Forms.Label();
            this.median_y_label = new System.Windows.Forms.Label();
            this.median_x_label = new System.Windows.Forms.Label();
            this.deltaAvg_z_label_value = new System.Windows.Forms.Label();
            this.deltaAvg_y_label_value = new System.Windows.Forms.Label();
            this.deltaAvg_x_label_value = new System.Windows.Forms.Label();
            this.deltaAvg_z_label = new System.Windows.Forms.Label();
            this.deltaAvg_y_label = new System.Windows.Forms.Label();
            this.deltaAvg_x_label = new System.Windows.Forms.Label();
            this.deltaMax_z_label_value = new System.Windows.Forms.Label();
            this.deltaMax_y_label_value = new System.Windows.Forms.Label();
            this.deltaMax_x_label_value = new System.Windows.Forms.Label();
            this.deltaMax_z_label = new System.Windows.Forms.Label();
            this.deltaMax_y_label = new System.Windows.Forms.Label();
            this.deltaMax_x_label = new System.Windows.Forms.Label();
            this.variance_z_label_value = new System.Windows.Forms.Label();
            this.variance_y_label_value = new System.Windows.Forms.Label();
            this.variance_z_label = new System.Windows.Forms.Label();
            this.variance_y_label = new System.Windows.Forms.Label();
            this.variance_x_label_value = new System.Windows.Forms.Label();
            this.variance_x_label = new System.Windows.Forms.Label();
            this.min_z_label_value = new System.Windows.Forms.Label();
            this.min_y_label_value = new System.Windows.Forms.Label();
            this.min_x_label_value = new System.Windows.Forms.Label();
            this.max_z_label_value = new System.Windows.Forms.Label();
            this.max_y_label_value = new System.Windows.Forms.Label();
            this.max_x_label_value = new System.Windows.Forms.Label();
            this.mix_z_label = new System.Windows.Forms.Label();
            this.mix_y_label = new System.Windows.Forms.Label();
            this.mix_x_label = new System.Windows.Forms.Label();
            this.max_z_label = new System.Windows.Forms.Label();
            this.max_y_label = new System.Windows.Forms.Label();
            this.max_x_label = new System.Windows.Forms.Label();
            this.average_z_label_value = new System.Windows.Forms.Label();
            this.average_y_label_value = new System.Windows.Forms.Label();
            this.average_x_label_value = new System.Windows.Forms.Label();
            this.average_z_label = new System.Windows.Forms.Label();
            this.average_y_label = new System.Windows.Forms.Label();
            this.average_x_label = new System.Windows.Forms.Label();
            this.viewportLayout1 = new devDept.Eyeshot.ViewportLayout();
            this.valid_measure_count_label = new System.Windows.Forms.Label();
            this.invalid_measure_count_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewportLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Measurement,
            this.Axis,
            this.Value,
            this.Nominal,
            this.ToleranceLower,
            this.ToleranceUpper});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(759, 577);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_DefaultValuesNeeded);
            // 
            // Measurement
            // 
            this.Measurement.HeaderText = "Measurement";
            this.Measurement.Name = "Measurement";
            // 
            // Axis
            // 
            this.Axis.HeaderText = "Axis";
            this.Axis.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.Axis.Name = "Axis";
            this.Axis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Axis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.Name = "Nominal";
            // 
            // ToleranceLower
            // 
            this.ToleranceLower.HeaderText = "Tolerance Lower";
            this.ToleranceLower.Name = "ToleranceLower";
            // 
            // ToleranceUpper
            // 
            this.ToleranceUpper.HeaderText = "Tolerance Upper";
            this.ToleranceUpper.Name = "ToleranceUpper";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.invalid_measure_count_label);
            this.panel1.Controls.Add(this.valid_measure_count_label);
            this.panel1.Controls.Add(this.invalid_measure_label);
            this.panel1.Controls.Add(this.valid_measure_label);
            this.panel1.Controls.Add(this.median_z_label_value);
            this.panel1.Controls.Add(this.median_y_label_value);
            this.panel1.Controls.Add(this.median_x_label_value);
            this.panel1.Controls.Add(this.median_z_label);
            this.panel1.Controls.Add(this.median_y_label);
            this.panel1.Controls.Add(this.median_x_label);
            this.panel1.Controls.Add(this.deltaAvg_z_label_value);
            this.panel1.Controls.Add(this.deltaAvg_y_label_value);
            this.panel1.Controls.Add(this.deltaAvg_x_label_value);
            this.panel1.Controls.Add(this.deltaAvg_z_label);
            this.panel1.Controls.Add(this.deltaAvg_y_label);
            this.panel1.Controls.Add(this.deltaAvg_x_label);
            this.panel1.Controls.Add(this.deltaMax_z_label_value);
            this.panel1.Controls.Add(this.deltaMax_y_label_value);
            this.panel1.Controls.Add(this.deltaMax_x_label_value);
            this.panel1.Controls.Add(this.deltaMax_z_label);
            this.panel1.Controls.Add(this.deltaMax_y_label);
            this.panel1.Controls.Add(this.deltaMax_x_label);
            this.panel1.Controls.Add(this.variance_z_label_value);
            this.panel1.Controls.Add(this.variance_y_label_value);
            this.panel1.Controls.Add(this.variance_z_label);
            this.panel1.Controls.Add(this.variance_y_label);
            this.panel1.Controls.Add(this.variance_x_label_value);
            this.panel1.Controls.Add(this.variance_x_label);
            this.panel1.Controls.Add(this.min_z_label_value);
            this.panel1.Controls.Add(this.min_y_label_value);
            this.panel1.Controls.Add(this.min_x_label_value);
            this.panel1.Controls.Add(this.max_z_label_value);
            this.panel1.Controls.Add(this.max_y_label_value);
            this.panel1.Controls.Add(this.max_x_label_value);
            this.panel1.Controls.Add(this.mix_z_label);
            this.panel1.Controls.Add(this.mix_y_label);
            this.panel1.Controls.Add(this.mix_x_label);
            this.panel1.Controls.Add(this.max_z_label);
            this.panel1.Controls.Add(this.max_y_label);
            this.panel1.Controls.Add(this.max_x_label);
            this.panel1.Controls.Add(this.average_z_label_value);
            this.panel1.Controls.Add(this.average_y_label_value);
            this.panel1.Controls.Add(this.average_x_label_value);
            this.panel1.Controls.Add(this.average_z_label);
            this.panel1.Controls.Add(this.average_y_label);
            this.panel1.Controls.Add(this.average_x_label);
            this.panel1.Location = new System.Drawing.Point(654, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 577);
            this.panel1.TabIndex = 3;
            // 
            // invalid_measure_label
            // 
            this.invalid_measure_label.AutoSize = true;
            this.invalid_measure_label.Location = new System.Drawing.Point(3, 384);
            this.invalid_measure_label.Name = "invalid_measure_label";
            this.invalid_measure_label.Size = new System.Drawing.Size(112, 13);
            this.invalid_measure_label.TabIndex = 43;
            this.invalid_measure_label.Text = "Invalid measurements:";
            // 
            // valid_measure_label
            // 
            this.valid_measure_label.AutoSize = true;
            this.valid_measure_label.Location = new System.Drawing.Point(3, 358);
            this.valid_measure_label.Name = "valid_measure_label";
            this.valid_measure_label.Size = new System.Drawing.Size(104, 13);
            this.valid_measure_label.TabIndex = 42;
            this.valid_measure_label.Text = "Valid measurements:";
            // 
            // median_z_label_value
            // 
            this.median_z_label_value.AutoSize = true;
            this.median_z_label_value.Location = new System.Drawing.Point(69, 319);
            this.median_z_label_value.Name = "median_z_label_value";
            this.median_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.median_z_label_value.TabIndex = 41;
            this.median_z_label_value.Text = "0";
            // 
            // median_y_label_value
            // 
            this.median_y_label_value.AutoSize = true;
            this.median_y_label_value.Location = new System.Drawing.Point(69, 306);
            this.median_y_label_value.Name = "median_y_label_value";
            this.median_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.median_y_label_value.TabIndex = 40;
            this.median_y_label_value.Text = "0";
            // 
            // median_x_label_value
            // 
            this.median_x_label_value.AutoSize = true;
            this.median_x_label_value.Location = new System.Drawing.Point(69, 293);
            this.median_x_label_value.Name = "median_x_label_value";
            this.median_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.median_x_label_value.TabIndex = 39;
            this.median_x_label_value.Text = "0";
            // 
            // median_z_label
            // 
            this.median_z_label.AutoSize = true;
            this.median_z_label.Location = new System.Drawing.Point(3, 319);
            this.median_z_label.Name = "median_z_label";
            this.median_z_label.Size = new System.Drawing.Size(55, 13);
            this.median_z_label.TabIndex = 38;
            this.median_z_label.Text = "Median Z:";
            // 
            // median_y_label
            // 
            this.median_y_label.AutoSize = true;
            this.median_y_label.Location = new System.Drawing.Point(3, 306);
            this.median_y_label.Name = "median_y_label";
            this.median_y_label.Size = new System.Drawing.Size(55, 13);
            this.median_y_label.TabIndex = 37;
            this.median_y_label.Text = "Median Y:";
            // 
            // median_x_label
            // 
            this.median_x_label.AutoSize = true;
            this.median_x_label.Location = new System.Drawing.Point(3, 293);
            this.median_x_label.Name = "median_x_label";
            this.median_x_label.Size = new System.Drawing.Size(55, 13);
            this.median_x_label.TabIndex = 36;
            this.median_x_label.Text = "Median X:";
            // 
            // deltaAvg_z_label_value
            // 
            this.deltaAvg_z_label_value.AutoSize = true;
            this.deltaAvg_z_label_value.Location = new System.Drawing.Point(69, 271);
            this.deltaAvg_z_label_value.Name = "deltaAvg_z_label_value";
            this.deltaAvg_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaAvg_z_label_value.TabIndex = 35;
            this.deltaAvg_z_label_value.Text = "0";
            // 
            // deltaAvg_y_label_value
            // 
            this.deltaAvg_y_label_value.AutoSize = true;
            this.deltaAvg_y_label_value.Location = new System.Drawing.Point(69, 258);
            this.deltaAvg_y_label_value.Name = "deltaAvg_y_label_value";
            this.deltaAvg_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaAvg_y_label_value.TabIndex = 34;
            this.deltaAvg_y_label_value.Text = "0";
            // 
            // deltaAvg_x_label_value
            // 
            this.deltaAvg_x_label_value.AutoSize = true;
            this.deltaAvg_x_label_value.Location = new System.Drawing.Point(69, 245);
            this.deltaAvg_x_label_value.Name = "deltaAvg_x_label_value";
            this.deltaAvg_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaAvg_x_label_value.TabIndex = 33;
            this.deltaAvg_x_label_value.Text = "0";
            // 
            // deltaAvg_z_label
            // 
            this.deltaAvg_z_label.AutoSize = true;
            this.deltaAvg_z_label.Location = new System.Drawing.Point(3, 271);
            this.deltaAvg_z_label.Name = "deltaAvg_z_label";
            this.deltaAvg_z_label.Size = new System.Drawing.Size(64, 13);
            this.deltaAvg_z_label.TabIndex = 32;
            this.deltaAvg_z_label.Text = "DeltaAvg Z:";
            // 
            // deltaAvg_y_label
            // 
            this.deltaAvg_y_label.AutoSize = true;
            this.deltaAvg_y_label.Location = new System.Drawing.Point(3, 258);
            this.deltaAvg_y_label.Name = "deltaAvg_y_label";
            this.deltaAvg_y_label.Size = new System.Drawing.Size(64, 13);
            this.deltaAvg_y_label.TabIndex = 30;
            this.deltaAvg_y_label.Text = "DeltaAvg Y:";
            // 
            // deltaAvg_x_label
            // 
            this.deltaAvg_x_label.AutoSize = true;
            this.deltaAvg_x_label.Location = new System.Drawing.Point(3, 245);
            this.deltaAvg_x_label.Name = "deltaAvg_x_label";
            this.deltaAvg_x_label.Size = new System.Drawing.Size(64, 13);
            this.deltaAvg_x_label.TabIndex = 31;
            this.deltaAvg_x_label.Text = "DeltaAvg X:";
            // 
            // deltaMax_z_label_value
            // 
            this.deltaMax_z_label_value.AutoSize = true;
            this.deltaMax_z_label_value.Location = new System.Drawing.Point(69, 223);
            this.deltaMax_z_label_value.Name = "deltaMax_z_label_value";
            this.deltaMax_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaMax_z_label_value.TabIndex = 29;
            this.deltaMax_z_label_value.Text = "0";
            // 
            // deltaMax_y_label_value
            // 
            this.deltaMax_y_label_value.AutoSize = true;
            this.deltaMax_y_label_value.Location = new System.Drawing.Point(69, 210);
            this.deltaMax_y_label_value.Name = "deltaMax_y_label_value";
            this.deltaMax_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaMax_y_label_value.TabIndex = 28;
            this.deltaMax_y_label_value.Text = "0";
            // 
            // deltaMax_x_label_value
            // 
            this.deltaMax_x_label_value.AutoSize = true;
            this.deltaMax_x_label_value.Location = new System.Drawing.Point(69, 197);
            this.deltaMax_x_label_value.Name = "deltaMax_x_label_value";
            this.deltaMax_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.deltaMax_x_label_value.TabIndex = 27;
            this.deltaMax_x_label_value.Text = "0";
            // 
            // deltaMax_z_label
            // 
            this.deltaMax_z_label.AutoSize = true;
            this.deltaMax_z_label.Location = new System.Drawing.Point(3, 223);
            this.deltaMax_z_label.Name = "deltaMax_z_label";
            this.deltaMax_z_label.Size = new System.Drawing.Size(65, 13);
            this.deltaMax_z_label.TabIndex = 26;
            this.deltaMax_z_label.Text = "DeltaMax Z:";
            // 
            // deltaMax_y_label
            // 
            this.deltaMax_y_label.AutoSize = true;
            this.deltaMax_y_label.Location = new System.Drawing.Point(3, 210);
            this.deltaMax_y_label.Name = "deltaMax_y_label";
            this.deltaMax_y_label.Size = new System.Drawing.Size(65, 13);
            this.deltaMax_y_label.TabIndex = 25;
            this.deltaMax_y_label.Text = "DeltaMax Y:";
            // 
            // deltaMax_x_label
            // 
            this.deltaMax_x_label.AutoSize = true;
            this.deltaMax_x_label.Location = new System.Drawing.Point(3, 197);
            this.deltaMax_x_label.Name = "deltaMax_x_label";
            this.deltaMax_x_label.Size = new System.Drawing.Size(65, 13);
            this.deltaMax_x_label.TabIndex = 24;
            this.deltaMax_x_label.Text = "DeltaMax X:";
            // 
            // variance_z_label_value
            // 
            this.variance_z_label_value.AutoSize = true;
            this.variance_z_label_value.Location = new System.Drawing.Point(69, 174);
            this.variance_z_label_value.Name = "variance_z_label_value";
            this.variance_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.variance_z_label_value.TabIndex = 23;
            this.variance_z_label_value.Text = "0";
            // 
            // variance_y_label_value
            // 
            this.variance_y_label_value.AutoSize = true;
            this.variance_y_label_value.Location = new System.Drawing.Point(69, 161);
            this.variance_y_label_value.Name = "variance_y_label_value";
            this.variance_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.variance_y_label_value.TabIndex = 22;
            this.variance_y_label_value.Text = "0";
            // 
            // variance_z_label
            // 
            this.variance_z_label.AutoSize = true;
            this.variance_z_label.Location = new System.Drawing.Point(3, 174);
            this.variance_z_label.Name = "variance_z_label";
            this.variance_z_label.Size = new System.Drawing.Size(62, 13);
            this.variance_z_label.TabIndex = 21;
            this.variance_z_label.Text = "Variance Z:";
            // 
            // variance_y_label
            // 
            this.variance_y_label.AutoSize = true;
            this.variance_y_label.Location = new System.Drawing.Point(3, 161);
            this.variance_y_label.Name = "variance_y_label";
            this.variance_y_label.Size = new System.Drawing.Size(62, 13);
            this.variance_y_label.TabIndex = 20;
            this.variance_y_label.Text = "Variance Y:";
            // 
            // variance_x_label_value
            // 
            this.variance_x_label_value.AutoSize = true;
            this.variance_x_label_value.Location = new System.Drawing.Point(69, 148);
            this.variance_x_label_value.Name = "variance_x_label_value";
            this.variance_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.variance_x_label_value.TabIndex = 19;
            this.variance_x_label_value.Text = "0";
            // 
            // variance_x_label
            // 
            this.variance_x_label.AutoSize = true;
            this.variance_x_label.Location = new System.Drawing.Point(3, 148);
            this.variance_x_label.Name = "variance_x_label";
            this.variance_x_label.Size = new System.Drawing.Size(62, 13);
            this.variance_x_label.TabIndex = 18;
            this.variance_x_label.Text = "Variance X:";
            // 
            // min_z_label_value
            // 
            this.min_z_label_value.AutoSize = true;
            this.min_z_label_value.Location = new System.Drawing.Point(69, 123);
            this.min_z_label_value.Name = "min_z_label_value";
            this.min_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.min_z_label_value.TabIndex = 17;
            this.min_z_label_value.Text = "0";
            // 
            // min_y_label_value
            // 
            this.min_y_label_value.AutoSize = true;
            this.min_y_label_value.Location = new System.Drawing.Point(69, 110);
            this.min_y_label_value.Name = "min_y_label_value";
            this.min_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.min_y_label_value.TabIndex = 16;
            this.min_y_label_value.Text = "0";
            // 
            // min_x_label_value
            // 
            this.min_x_label_value.AutoSize = true;
            this.min_x_label_value.Location = new System.Drawing.Point(69, 97);
            this.min_x_label_value.Name = "min_x_label_value";
            this.min_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.min_x_label_value.TabIndex = 15;
            this.min_x_label_value.Text = "0";
            // 
            // max_z_label_value
            // 
            this.max_z_label_value.AutoSize = true;
            this.max_z_label_value.Location = new System.Drawing.Point(69, 75);
            this.max_z_label_value.Name = "max_z_label_value";
            this.max_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.max_z_label_value.TabIndex = 14;
            this.max_z_label_value.Text = "0";
            // 
            // max_y_label_value
            // 
            this.max_y_label_value.AutoSize = true;
            this.max_y_label_value.Location = new System.Drawing.Point(69, 62);
            this.max_y_label_value.Name = "max_y_label_value";
            this.max_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.max_y_label_value.TabIndex = 13;
            this.max_y_label_value.Text = "0";
            // 
            // max_x_label_value
            // 
            this.max_x_label_value.AutoSize = true;
            this.max_x_label_value.Location = new System.Drawing.Point(69, 49);
            this.max_x_label_value.Name = "max_x_label_value";
            this.max_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.max_x_label_value.TabIndex = 12;
            this.max_x_label_value.Text = "0";
            // 
            // mix_z_label
            // 
            this.mix_z_label.AutoSize = true;
            this.mix_z_label.Location = new System.Drawing.Point(3, 123);
            this.mix_z_label.Name = "mix_z_label";
            this.mix_z_label.Size = new System.Drawing.Size(37, 13);
            this.mix_z_label.TabIndex = 11;
            this.mix_z_label.Text = "Min Z:";
            // 
            // mix_y_label
            // 
            this.mix_y_label.AutoSize = true;
            this.mix_y_label.Location = new System.Drawing.Point(3, 110);
            this.mix_y_label.Name = "mix_y_label";
            this.mix_y_label.Size = new System.Drawing.Size(37, 13);
            this.mix_y_label.TabIndex = 10;
            this.mix_y_label.Text = "Min Y:";
            // 
            // mix_x_label
            // 
            this.mix_x_label.AutoSize = true;
            this.mix_x_label.Location = new System.Drawing.Point(3, 97);
            this.mix_x_label.Name = "mix_x_label";
            this.mix_x_label.Size = new System.Drawing.Size(37, 13);
            this.mix_x_label.TabIndex = 9;
            this.mix_x_label.Text = "Min X:";
            // 
            // max_z_label
            // 
            this.max_z_label.AutoSize = true;
            this.max_z_label.Location = new System.Drawing.Point(3, 75);
            this.max_z_label.Name = "max_z_label";
            this.max_z_label.Size = new System.Drawing.Size(40, 13);
            this.max_z_label.TabIndex = 8;
            this.max_z_label.Text = "Max Z:";
            // 
            // max_y_label
            // 
            this.max_y_label.AutoSize = true;
            this.max_y_label.Location = new System.Drawing.Point(3, 62);
            this.max_y_label.Name = "max_y_label";
            this.max_y_label.Size = new System.Drawing.Size(40, 13);
            this.max_y_label.TabIndex = 7;
            this.max_y_label.Text = "Max Y:";
            // 
            // max_x_label
            // 
            this.max_x_label.AutoSize = true;
            this.max_x_label.Location = new System.Drawing.Point(3, 49);
            this.max_x_label.Name = "max_x_label";
            this.max_x_label.Size = new System.Drawing.Size(40, 13);
            this.max_x_label.TabIndex = 6;
            this.max_x_label.Text = "Max X:";
            // 
            // average_z_label_value
            // 
            this.average_z_label_value.AutoSize = true;
            this.average_z_label_value.Location = new System.Drawing.Point(69, 26);
            this.average_z_label_value.Name = "average_z_label_value";
            this.average_z_label_value.Size = new System.Drawing.Size(13, 13);
            this.average_z_label_value.TabIndex = 5;
            this.average_z_label_value.Text = "0";
            // 
            // average_y_label_value
            // 
            this.average_y_label_value.AutoSize = true;
            this.average_y_label_value.Location = new System.Drawing.Point(69, 13);
            this.average_y_label_value.Name = "average_y_label_value";
            this.average_y_label_value.Size = new System.Drawing.Size(13, 13);
            this.average_y_label_value.TabIndex = 4;
            this.average_y_label_value.Text = "0";
            // 
            // average_x_label_value
            // 
            this.average_x_label_value.AutoSize = true;
            this.average_x_label_value.Location = new System.Drawing.Point(69, 0);
            this.average_x_label_value.Name = "average_x_label_value";
            this.average_x_label_value.Size = new System.Drawing.Size(13, 13);
            this.average_x_label_value.TabIndex = 3;
            this.average_x_label_value.Text = "0";
            // 
            // average_z_label
            // 
            this.average_z_label.AutoSize = true;
            this.average_z_label.Location = new System.Drawing.Point(3, 26);
            this.average_z_label.Name = "average_z_label";
            this.average_z_label.Size = new System.Drawing.Size(60, 13);
            this.average_z_label.TabIndex = 2;
            this.average_z_label.Text = "Average Z:";
            // 
            // average_y_label
            // 
            this.average_y_label.AutoSize = true;
            this.average_y_label.Location = new System.Drawing.Point(3, 13);
            this.average_y_label.Name = "average_y_label";
            this.average_y_label.Size = new System.Drawing.Size(60, 13);
            this.average_y_label.TabIndex = 1;
            this.average_y_label.Text = "Average Y:";
            // 
            // average_x_label
            // 
            this.average_x_label.AutoSize = true;
            this.average_x_label.Location = new System.Drawing.Point(3, 0);
            this.average_x_label.Name = "average_x_label";
            this.average_x_label.Size = new System.Drawing.Size(60, 13);
            this.average_x_label.TabIndex = 0;
            this.average_x_label.Text = "Average X:";
            // 
            // viewportLayout1
            // 
            this.viewportLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewportLayout1.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewportLayout1.Location = new System.Drawing.Point(778, 12);
            this.viewportLayout1.Name = "viewportLayout1";
            this.viewportLayout1.ProgressBar = progressBar2;
            this.viewportLayout1.Size = new System.Drawing.Size(524, 577);
            this.viewportLayout1.TabIndex = 4;
            this.viewportLayout1.Text = "viewportLayout1";
            coordinateSystemIcon2.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewport2.CoordinateSystemIcon = coordinateSystemIcon2;
            viewport2.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol2.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewport2.OriginSymbol = originSymbol2;
            viewCubeIcon2.Font = null;
            viewCubeIcon2.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport2.ViewCubeIcon = viewCubeIcon2;
            this.viewportLayout1.Viewports.Add(viewport2);
            this.viewportLayout1.Click += new System.EventHandler(this.viewportLayout1_Click);
            // 
            // valid_measure_count_label
            // 
            this.valid_measure_count_label.AutoSize = true;
            this.valid_measure_count_label.Location = new System.Drawing.Point(3, 371);
            this.valid_measure_count_label.Name = "valid_measure_count_label";
            this.valid_measure_count_label.Size = new System.Drawing.Size(13, 13);
            this.valid_measure_count_label.TabIndex = 44;
            this.valid_measure_count_label.Text = "0";
            // 
            // invalid_measure_count_label
            // 
            this.invalid_measure_count_label.AutoSize = true;
            this.invalid_measure_count_label.Location = new System.Drawing.Point(3, 397);
            this.invalid_measure_count_label.Name = "invalid_measure_count_label";
            this.invalid_measure_count_label.Size = new System.Drawing.Size(13, 13);
            this.invalid_measure_count_label.TabIndex = 45;
            this.invalid_measure_count_label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 587);
            this.Controls.Add(this.viewportLayout1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewportLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurement;
        private System.Windows.Forms.DataGridViewComboBoxColumn Axis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToleranceLower;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToleranceUpper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label invalid_measure_label;
        private System.Windows.Forms.Label valid_measure_label;
        private System.Windows.Forms.Label median_z_label_value;
        private System.Windows.Forms.Label median_y_label_value;
        private System.Windows.Forms.Label median_x_label_value;
        private System.Windows.Forms.Label median_z_label;
        private System.Windows.Forms.Label median_y_label;
        private System.Windows.Forms.Label median_x_label;
        private System.Windows.Forms.Label deltaAvg_z_label_value;
        private System.Windows.Forms.Label deltaAvg_y_label_value;
        private System.Windows.Forms.Label deltaAvg_x_label_value;
        private System.Windows.Forms.Label deltaAvg_z_label;
        private System.Windows.Forms.Label deltaAvg_y_label;
        private System.Windows.Forms.Label deltaAvg_x_label;
        private System.Windows.Forms.Label deltaMax_z_label_value;
        private System.Windows.Forms.Label deltaMax_y_label_value;
        private System.Windows.Forms.Label deltaMax_x_label_value;
        private System.Windows.Forms.Label deltaMax_z_label;
        private System.Windows.Forms.Label deltaMax_y_label;
        private System.Windows.Forms.Label deltaMax_x_label;
        private System.Windows.Forms.Label variance_z_label_value;
        private System.Windows.Forms.Label variance_y_label_value;
        private System.Windows.Forms.Label variance_z_label;
        private System.Windows.Forms.Label variance_y_label;
        private System.Windows.Forms.Label variance_x_label_value;
        private System.Windows.Forms.Label variance_x_label;
        private System.Windows.Forms.Label min_z_label_value;
        private System.Windows.Forms.Label min_y_label_value;
        private System.Windows.Forms.Label min_x_label_value;
        private System.Windows.Forms.Label max_z_label_value;
        private System.Windows.Forms.Label max_y_label_value;
        private System.Windows.Forms.Label max_x_label_value;
        private System.Windows.Forms.Label mix_z_label;
        private System.Windows.Forms.Label mix_y_label;
        private System.Windows.Forms.Label mix_x_label;
        private System.Windows.Forms.Label max_z_label;
        private System.Windows.Forms.Label max_y_label;
        private System.Windows.Forms.Label max_x_label;
        private System.Windows.Forms.Label average_z_label_value;
        private System.Windows.Forms.Label average_y_label_value;
        private System.Windows.Forms.Label average_x_label_value;
        private System.Windows.Forms.Label average_z_label;
        private System.Windows.Forms.Label average_y_label;
        private System.Windows.Forms.Label average_x_label;
        private devDept.Eyeshot.ViewportLayout viewportLayout1;
        private System.Windows.Forms.Label invalid_measure_count_label;
        private System.Windows.Forms.Label valid_measure_count_label;
    }
}

