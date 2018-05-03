// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

#pragma warning disable 1591,0618,0105,0672

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

using Eto;
using Eto.Forms;

namespace Eto
{
    public static class EventsMixin
    {
        public static PlatformEvents Events(this Platform This)
        {
            return new PlatformEvents(This);
        }
        public static WidgetEvents Events(this Widget This)
        {
            return new WidgetEvents(This);
        }
    }

    public class PlatformEvents
    {
        Platform This;

        public PlatformEvents(Platform This)
        {
            this.This = This;
        }


        public IObservable<Eto.HandlerCreatedEventArgs> HandlerCreated {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.HandlerCreatedEventArgs>, Eto.HandlerCreatedEventArgs>(x => This.HandlerCreated += x, x => This.HandlerCreated -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.WidgetCreatedEventArgs> WidgetCreated {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.WidgetCreatedEventArgs>, Eto.WidgetCreatedEventArgs>(x => This.WidgetCreated += x, x => This.WidgetCreated -= x).Select(x => x.EventArgs); }
        }

    }
    public class WidgetEvents
    {
        Widget This;

        public WidgetEvents(Widget This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> StyleChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.StyleChanged += x, x => This.StyleChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Eto.Forms
{
    public static class EventsMixin
    {
        public static ApplicationEvents Events(this Application This)
        {
            return new ApplicationEvents(This);
        }
        public static BindableWidgetEvents Events(this BindableWidget This)
        {
            return new BindableWidgetEvents(This);
        }
        public static BindingEvents Events(this Binding This)
        {
            return new BindingEvents(This);
        }
        public static IBindableEvents Events(this IBindable This)
        {
            return new IBindableEvents(This);
        }
        public static CellEventArgsEvents Events(this CellEventArgs This)
        {
            return new CellEventArgsEvents(This);
        }
        public static CustomCellEvents Events(this CustomCell This)
        {
            return new CustomCellEvents(This);
        }
        public static DrawableCellEvents Events(this DrawableCell This)
        {
            return new DrawableCellEvents(This);
        }
        public static ColorDialogEvents Events(this ColorDialog This)
        {
            return new ColorDialogEvents(This);
        }
        public static CheckCommandEvents Events(this CheckCommand This)
        {
            return new CheckCommandEvents(This);
        }
        public static CommandEvents Events(this Command This)
        {
            return new CommandEvents(This);
        }
        public static ButtonEvents Events(this Button This)
        {
            return new ButtonEvents(This);
        }
        public static CalendarEvents Events(this Calendar This)
        {
            return new CalendarEvents(This);
        }
        public static CheckBoxEvents Events(this CheckBox This)
        {
            return new CheckBoxEvents(This);
        }
        public static ColorPickerEvents Events(this ColorPicker This)
        {
            return new ColorPickerEvents(This);
        }
        public static ComboBoxEvents Events(this ComboBox This)
        {
            return new ComboBoxEvents(This);
        }
        public static ControlEvents Events(this Control This)
        {
            return new ControlEvents(This);
        }
        public static DateTimePickerEvents Events(this DateTimePicker This)
        {
            return new DateTimePickerEvents(This);
        }
        public static DocumentControlEvents Events(this DocumentControl This)
        {
            return new DocumentControlEvents(This);
        }
        public static DocumentPageEvents Events(this DocumentPage This)
        {
            return new DocumentPageEvents(This);
        }
        public static DrawableEvents Events(this Drawable This)
        {
            return new DrawableEvents(This);
        }
        public static DropDownEvents Events(this DropDown This)
        {
            return new DropDownEvents(This);
        }
        public static ExpanderEvents Events(this Expander This)
        {
            return new ExpanderEvents(This);
        }
        public static FilePickerEvents Events(this FilePicker This)
        {
            return new FilePickerEvents(This);
        }
        public static FontPickerEvents Events(this FontPicker This)
        {
            return new FontPickerEvents(This);
        }
        public static GridEvents Events(this Grid This)
        {
            return new GridEvents(This);
        }
        public static LinkButtonEvents Events(this LinkButton This)
        {
            return new LinkButtonEvents(This);
        }
        public static ListBoxEvents Events(this ListBox This)
        {
            return new ListBoxEvents(This);
        }
        public static ListControlEvents Events(this ListControl This)
        {
            return new ListControlEvents(This);
        }
        public static NavigationEvents Events(this Navigation This)
        {
            return new NavigationEvents(This);
        }
        public static NumericStepperEvents Events(this NumericStepper This)
        {
            return new NumericStepperEvents(This);
        }
        public static RadioButtonEvents Events(this RadioButton This)
        {
            return new RadioButtonEvents(This);
        }
        public static RadioButtonListEvents Events(this RadioButtonList This)
        {
            return new RadioButtonListEvents(This);
        }
        public static ScrollableEvents Events(this Scrollable This)
        {
            return new ScrollableEvents(This);
        }
        public static SliderEvents Events(this Slider This)
        {
            return new SliderEvents(This);
        }
        public static SplitterEvents Events(this Splitter This)
        {
            return new SplitterEvents(This);
        }
        public static StepperEvents Events(this Stepper This)
        {
            return new StepperEvents(This);
        }
        public static TabControlEvents Events(this TabControl This)
        {
            return new TabControlEvents(This);
        }
        public static TabPageEvents Events(this TabPage This)
        {
            return new TabPageEvents(This);
        }
        public static TextAreaEvents Events(this TextArea This)
        {
            return new TextAreaEvents(This);
        }
        public static TextBoxEvents Events(this TextBox This)
        {
            return new TextBoxEvents(This);
        }
        public static TextControlEvents Events(this TextControl This)
        {
            return new TextControlEvents(This);
        }
        public static TextStepperEvents Events(this TextStepper This)
        {
            return new TextStepperEvents(This);
        }
        public static TreeGridViewEvents Events(this TreeGridView This)
        {
            return new TreeGridViewEvents(This);
        }
        public static TreeItemEvents Events(this TreeItem This)
        {
            return new TreeItemEvents(This);
        }
        public static TreeViewEvents Events(this TreeView This)
        {
            return new TreeViewEvents(This);
        }
        public static WebViewEvents Events(this WebView This)
        {
            return new WebViewEvents(This);
        }
        public static FontDialogEvents Events(this FontDialog This)
        {
            return new FontDialogEvents(This);
        }
        public static IKeyboardInputSourceEvents Events(this IKeyboardInputSource This)
        {
            return new IKeyboardInputSourceEvents(This);
        }
        public static IMouseInputSourceEvents Events(this IMouseInputSource This)
        {
            return new IMouseInputSourceEvents(This);
        }
        public static CheckMenuItemEvents Events(this CheckMenuItem This)
        {
            return new CheckMenuItemEvents(This);
        }
        public static ContextMenuEvents Events(this ContextMenu This)
        {
            return new ContextMenuEvents(This);
        }
        public static ICommandItemEvents Events(this ICommandItem This)
        {
            return new ICommandItemEvents(This);
        }
        public static MenuItemEvents Events(this MenuItem This)
        {
            return new MenuItemEvents(This);
        }
        public static RadioMenuItemEvents Events(this RadioMenuItem This)
        {
            return new RadioMenuItemEvents(This);
        }
        public static NotificationEvents Events(this Notification This)
        {
            return new NotificationEvents(This);
        }
        public static PrintDocumentEvents Events(this PrintDocument This)
        {
            return new PrintDocumentEvents(This);
        }
        public static CheckToolItemEvents Events(this CheckToolItem This)
        {
            return new CheckToolItemEvents(This);
        }
        public static RadioToolItemEvents Events(this RadioToolItem This)
        {
            return new RadioToolItemEvents(This);
        }
        public static ToolItemEvents Events(this ToolItem This)
        {
            return new ToolItemEvents(This);
        }
        public static TrayIndicatorEvents Events(this TrayIndicator This)
        {
            return new TrayIndicatorEvents(This);
        }
        public static UITimerEvents Events(this UITimer This)
        {
            return new UITimerEvents(This);
        }
        public static WindowEvents Events(this Window This)
        {
            return new WindowEvents(This);
        }
    }

    public class ApplicationEvents
        : Eto.WidgetEvents
    {
        Application This;

        public ApplicationEvents(Application This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Initialized {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Initialized += x, x => This.Initialized -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.ComponentModel.CancelEventArgs> Terminating {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.Terminating += x, x => This.Terminating -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.UnhandledExceptionEventArgs> UnhandledException {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.UnhandledExceptionEventArgs>, Eto.UnhandledExceptionEventArgs>(x => This.UnhandledException += x, x => This.UnhandledException -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.NotificationEventArgs> NotificationActivated {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.NotificationEventArgs>, Eto.Forms.NotificationEventArgs>(x => This.NotificationActivated += x, x => This.NotificationActivated -= x).Select(x => x.EventArgs); }
        }

    }
    public class BindableWidgetEvents
        : Eto.WidgetEvents
    {
        BindableWidget This;

        public BindableWidgetEvents(BindableWidget This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> DataContextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.DataContextChanged += x, x => This.DataContextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class BindingEvents
    {
        Binding This;

        public BindingEvents(Binding This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.BindingChangingEventArgs> Changing {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.BindingChangingEventArgs>, Eto.Forms.BindingChangingEventArgs>(x => This.Changing += x, x => This.Changing -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.BindingChangedEventArgs> Changed {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.BindingChangedEventArgs>, Eto.Forms.BindingChangedEventArgs>(x => This.Changed += x, x => This.Changed -= x).Select(x => x.EventArgs); }
        }

    }
    public class IBindableEvents
    {
        IBindable This;

        public IBindableEvents(IBindable This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> DataContextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.DataContextChanged += x, x => This.DataContextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CellEventArgsEvents
    {
        CellEventArgs This;

        public CellEventArgsEvents(CellEventArgs This)
        {
            this.This = This;
        }


        public IObservable<System.ComponentModel.PropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<System.ComponentModel.PropertyChangedEventHandler, System.ComponentModel.PropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CustomCellEvents
        : Eto.WidgetEvents
    {
        CustomCell This;

        public CustomCellEvents(CustomCell This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.CellPaintEventArgs> Paint {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.CellPaintEventArgs>, Eto.Forms.CellPaintEventArgs>(x => This.Paint += x, x => This.Paint -= x).Select(x => x.EventArgs); }
        }

    }
    public class DrawableCellEvents
        : Eto.WidgetEvents
    {
        DrawableCell This;

        public DrawableCellEvents(DrawableCell This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.DrawableCellPaintEventArgs> Paint {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.DrawableCellPaintEventArgs>, Eto.Forms.DrawableCellPaintEventArgs>(x => This.Paint += x, x => This.Paint -= x).Select(x => x.EventArgs); }
        }

    }
    public class ColorDialogEvents
        : Eto.WidgetEvents
    {
        ColorDialog This;

        public ColorDialogEvents(ColorDialog This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> ColorChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.ColorChanged += x, x => This.ColorChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CheckCommandEvents
        : Eto.Forms.CommandEvents
    {
        CheckCommand This;

        public CheckCommandEvents(CheckCommand This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CommandEvents
    {
        Command This;

        public CommandEvents(Command This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> EnabledChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.EnabledChanged += x, x => This.EnabledChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> Executed {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Executed += x, x => This.Executed -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> DataContextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.DataContextChanged += x, x => This.DataContextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ButtonEvents
        : Eto.Forms.TextControlEvents
    {
        Button This;

        public ButtonEvents(Button This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class CalendarEvents
        : Eto.Forms.ControlEvents
    {
        Calendar This;

        public CalendarEvents(Calendar This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> SelectedDateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedDateChanged += x, x => This.SelectedDateChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedRangeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedRangeChanged += x, x => This.SelectedRangeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CheckBoxEvents
        : Eto.Forms.TextControlEvents
    {
        CheckBox This;

        public CheckBoxEvents(CheckBox This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ColorPickerEvents
        : Eto.Forms.ControlEvents
    {
        ColorPicker This;

        public ColorPickerEvents(ColorPicker This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ComboBoxEvents
        : Eto.Forms.DropDownEvents
    {
        ComboBox This;

        public ComboBoxEvents(ComboBox This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ControlEvents
        : Eto.Forms.BindableWidgetEvents
    {
        Control This;

        public ControlEvents(Control This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> SizeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.KeyEventArgs>, Eto.Forms.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.KeyEventArgs>, Eto.Forms.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TextInputEventArgs> TextInput {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TextInputEventArgs>, Eto.Forms.TextInputEventArgs>(x => This.TextInput += x, x => This.TextInput -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseDown {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseDown += x, x => This.MouseDown -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseUp {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseUp += x, x => This.MouseUp -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseMove {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseMove += x, x => This.MouseMove -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseLeave {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseLeave += x, x => This.MouseLeave -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseEnter {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseEnter += x, x => This.MouseEnter -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseDoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseDoubleClick += x, x => This.MouseDoubleClick -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseWheel {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseWheel += x, x => This.MouseWheel -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> GotFocus {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> LostFocus {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> Shown {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Shown += x, x => This.Shown -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> PreLoad {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.PreLoad += x, x => This.PreLoad -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> Load {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Load += x, x => This.Load -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> LoadComplete {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.LoadComplete += x, x => This.LoadComplete -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> UnLoad {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.UnLoad += x, x => This.UnLoad -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.DragEventArgs> DragDrop {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.DragEventArgs>, Eto.Forms.DragEventArgs>(x => This.DragDrop += x, x => This.DragDrop -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.DragEventArgs> DragOver {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.DragEventArgs>, Eto.Forms.DragEventArgs>(x => This.DragOver += x, x => This.DragOver -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.DragEventArgs> DragEnter {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.DragEventArgs>, Eto.Forms.DragEventArgs>(x => This.DragEnter += x, x => This.DragEnter -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.DragEventArgs> DragLeave {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.DragEventArgs>, Eto.Forms.DragEventArgs>(x => This.DragLeave += x, x => This.DragLeave -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> EnabledChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.EnabledChanged += x, x => This.EnabledChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DateTimePickerEvents
        : Eto.Forms.ControlEvents
    {
        DateTimePicker This;

        public DateTimePickerEvents(DateTimePicker This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DocumentControlEvents
        : Eto.Forms.ControlEvents
    {
        DocumentControl This;

        public DocumentControlEvents(DocumentControl This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.DocumentPageEventArgs> PageClosed {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.DocumentPageEventArgs>, Eto.Forms.DocumentPageEventArgs>(x => This.PageClosed += x, x => This.PageClosed -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.DocumentPageReorderEventArgs> PageReordered {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.DocumentPageReorderEventArgs>, Eto.Forms.DocumentPageReorderEventArgs>(x => This.PageReordered += x, x => This.PageReordered -= x).Select(x => x.EventArgs); }
        }

    }
    public class DocumentPageEvents
        : Eto.Forms.ControlEvents
    {
        DocumentPage This;

        public DocumentPageEvents(DocumentPage This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Closed {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class DrawableEvents
        : Eto.Forms.ControlEvents
    {
        Drawable This;

        public DrawableEvents(Drawable This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.PaintEventArgs> Paint {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.PaintEventArgs>, Eto.Forms.PaintEventArgs>(x => This.Paint += x, x => This.Paint -= x).Select(x => x.EventArgs); }
        }

    }
    public class DropDownEvents
        : Eto.Forms.ListControlEvents
    {
        DropDown This;

        public DropDownEvents(DropDown This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> DropDownOpening {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.DropDownOpening += x, x => This.DropDownOpening -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> DropDownClosed {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.DropDownClosed += x, x => This.DropDownClosed -= x).Select(x => x.EventArgs); }
        }

    }
    public class ExpanderEvents
        : Eto.Forms.ControlEvents
    {
        Expander This;

        public ExpanderEvents(Expander This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> ExpandedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.ExpandedChanged += x, x => This.ExpandedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class FilePickerEvents
        : Eto.Forms.ControlEvents
    {
        FilePicker This;

        public FilePickerEvents(FilePicker This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> FilePathChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.FilePathChanged += x, x => This.FilePathChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class FontPickerEvents
        : Eto.Forms.ControlEvents
    {
        FontPicker This;

        public FontPickerEvents(FontPicker This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class GridEvents
        : Eto.Forms.ControlEvents
    {
        Grid This;

        public GridEvents(Grid This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.GridViewCellEventArgs> CellEditing {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.GridViewCellEventArgs>, Eto.Forms.GridViewCellEventArgs>(x => This.CellEditing += x, x => This.CellEditing -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.GridViewCellEventArgs> CellEdited {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.GridViewCellEventArgs>, Eto.Forms.GridViewCellEventArgs>(x => This.CellEdited += x, x => This.CellEdited -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.GridCellMouseEventArgs> CellClick {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.GridCellMouseEventArgs>, Eto.Forms.GridCellMouseEventArgs>(x => This.CellClick += x, x => This.CellClick -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.GridCellMouseEventArgs> CellDoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.GridCellMouseEventArgs>, Eto.Forms.GridCellMouseEventArgs>(x => This.CellDoubleClick += x, x => This.CellDoubleClick -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.GridColumnEventArgs> ColumnHeaderClick {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.GridColumnEventArgs>, Eto.Forms.GridColumnEventArgs>(x => This.ColumnHeaderClick += x, x => This.ColumnHeaderClick -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.GridCellFormatEventArgs> CellFormatting {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.GridCellFormatEventArgs>, Eto.Forms.GridCellFormatEventArgs>(x => This.CellFormatting += x, x => This.CellFormatting -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedItemsChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedItemsChanged += x, x => This.SelectedItemsChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedRowsChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedRowsChanged += x, x => This.SelectedRowsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class LinkButtonEvents
        : Eto.Forms.TextControlEvents
    {
        LinkButton This;

        public LinkButtonEvents(LinkButton This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class ListBoxEvents
        : Eto.Forms.ListControlEvents
    {
        ListBox This;

        public ListBoxEvents(ListBox This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ListControlEvents
        : Eto.Forms.ControlEvents
    {
        ListControl This;

        public ListControlEvents(ListControl This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> SelectedIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedValueChanged += x, x => This.SelectedValueChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedKeyChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedKeyChanged += x, x => This.SelectedKeyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class NavigationEvents
        : Eto.Forms.ControlEvents
    {
        Navigation This;

        public NavigationEvents(Navigation This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.NavigationItemEventArgs> ItemShown {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.NavigationItemEventArgs>, Eto.Forms.NavigationItemEventArgs>(x => This.ItemShown += x, x => This.ItemShown -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.NavigationItemEventArgs> ItemRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.NavigationItemEventArgs>, Eto.Forms.NavigationItemEventArgs>(x => This.ItemRemoved += x, x => This.ItemRemoved -= x).Select(x => x.EventArgs); }
        }

    }
    public class NumericStepperEvents
        : Eto.Forms.ControlEvents
    {
        NumericStepper This;

        public NumericStepperEvents(NumericStepper This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadioButtonEvents
        : Eto.Forms.TextControlEvents
    {
        RadioButton This;

        public RadioButtonEvents(RadioButton This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadioButtonListEvents
        : Eto.Forms.ControlEvents
    {
        RadioButtonList This;

        public RadioButtonListEvents(RadioButtonList This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> SelectedIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedValueChanged += x, x => This.SelectedValueChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedKeyChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedKeyChanged += x, x => This.SelectedKeyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollableEvents
        : Eto.Forms.ControlEvents
    {
        Scrollable This;

        public ScrollableEvents(Scrollable This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.ScrollEventArgs> Scroll {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.ScrollEventArgs>, Eto.Forms.ScrollEventArgs>(x => This.Scroll += x, x => This.Scroll -= x).Select(x => x.EventArgs); }
        }

    }
    public class SliderEvents
        : Eto.Forms.ControlEvents
    {
        Slider This;

        public SliderEvents(Slider This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SplitterEvents
        : Eto.Forms.ControlEvents
    {
        Splitter This;

        public SplitterEvents(Splitter This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> PositionChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.PositionChanged += x, x => This.PositionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StepperEvents
        : Eto.Forms.ControlEvents
    {
        Stepper This;

        public StepperEvents(Stepper This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.StepperEventArgs> Step {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.StepperEventArgs>, Eto.Forms.StepperEventArgs>(x => This.Step += x, x => This.Step -= x).Select(x => x.EventArgs); }
        }

    }
    public class TabControlEvents
        : Eto.Forms.ControlEvents
    {
        TabControl This;

        public TabControlEvents(TabControl This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> SelectedIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TabPageEvents
        : Eto.Forms.ControlEvents
    {
        TabPage This;

        public TabPageEvents(TabPage This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextAreaEvents
        : Eto.Forms.TextControlEvents
    {
        TextArea This;

        public TextAreaEvents(TextArea This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> CaretIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CaretIndexChanged += x, x => This.CaretIndexChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextBoxEvents
        : Eto.Forms.TextControlEvents
    {
        TextBox This;

        public TextBoxEvents(TextBox This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.TextChangingEventArgs> TextChanging {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TextChangingEventArgs>, Eto.Forms.TextChangingEventArgs>(x => This.TextChanging += x, x => This.TextChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextControlEvents
        : Eto.Forms.ControlEvents
    {
        TextControl This;

        public TextControlEvents(TextControl This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextStepperEvents
        : Eto.Forms.TextBoxEvents
    {
        TextStepper This;

        public TextStepperEvents(TextStepper This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.StepperEventArgs> Step {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.StepperEventArgs>, Eto.Forms.StepperEventArgs>(x => This.Step += x, x => This.Step -= x).Select(x => x.EventArgs); }
        }

    }
    public class TreeGridViewEvents
        : Eto.Forms.GridEvents
    {
        TreeGridView This;

        public TreeGridViewEvents(TreeGridView This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.TreeGridViewItemEventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeGridViewItemEventArgs>, Eto.Forms.TreeGridViewItemEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeGridViewItemCancelEventArgs> Expanding {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeGridViewItemCancelEventArgs>, Eto.Forms.TreeGridViewItemCancelEventArgs>(x => This.Expanding += x, x => This.Expanding -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeGridViewItemEventArgs> Expanded {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeGridViewItemEventArgs>, Eto.Forms.TreeGridViewItemEventArgs>(x => This.Expanded += x, x => This.Expanded -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeGridViewItemCancelEventArgs> Collapsing {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeGridViewItemCancelEventArgs>, Eto.Forms.TreeGridViewItemCancelEventArgs>(x => This.Collapsing += x, x => This.Collapsing -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeGridViewItemEventArgs> Collapsed {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeGridViewItemEventArgs>, Eto.Forms.TreeGridViewItemEventArgs>(x => This.Collapsed += x, x => This.Collapsed -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectedItemChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectedItemChanged += x, x => This.SelectedItemChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TreeItemEvents
    {
        TreeItem This;

        public TreeItemEvents(TreeItem This)
        {
            this.This = This;
        }


        public IObservable<System.Collections.Specialized.NotifyCollectionChangedEventArgs> CollectionChanged {
            get { return Observable.FromEventPattern<System.Collections.Specialized.NotifyCollectionChangedEventHandler, System.Collections.Specialized.NotifyCollectionChangedEventArgs>(x => This.CollectionChanged += x, x => This.CollectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TreeViewEvents
        : Eto.Forms.ControlEvents
    {
        TreeView This;

        public TreeViewEvents(TreeView This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.TreeViewItemEventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeViewItemEventArgs>, Eto.Forms.TreeViewItemEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeViewItemCancelEventArgs> Expanding {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeViewItemCancelEventArgs>, Eto.Forms.TreeViewItemCancelEventArgs>(x => This.Expanding += x, x => This.Expanding -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeViewItemEventArgs> Expanded {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeViewItemEventArgs>, Eto.Forms.TreeViewItemEventArgs>(x => This.Expanded += x, x => This.Expanded -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeViewItemCancelEventArgs> Collapsing {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeViewItemCancelEventArgs>, Eto.Forms.TreeViewItemCancelEventArgs>(x => This.Collapsing += x, x => This.Collapsing -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeViewItemEventArgs> Collapsed {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeViewItemEventArgs>, Eto.Forms.TreeViewItemEventArgs>(x => This.Collapsed += x, x => This.Collapsed -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeViewItemEditEventArgs> LabelEdited {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeViewItemEditEventArgs>, Eto.Forms.TreeViewItemEditEventArgs>(x => This.LabelEdited += x, x => This.LabelEdited -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeViewItemCancelEventArgs> LabelEditing {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeViewItemCancelEventArgs>, Eto.Forms.TreeViewItemCancelEventArgs>(x => This.LabelEditing += x, x => This.LabelEditing -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TreeViewItemEventArgs> NodeMouseClick {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TreeViewItemEventArgs>, Eto.Forms.TreeViewItemEventArgs>(x => This.NodeMouseClick += x, x => This.NodeMouseClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class WebViewEvents
        : Eto.Forms.ControlEvents
    {
        WebView This;

        public WebViewEvents(WebView This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.WebViewLoadedEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.WebViewLoadedEventArgs>, Eto.Forms.WebViewLoadedEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.WebViewLoadedEventArgs> DocumentLoaded {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.WebViewLoadedEventArgs>, Eto.Forms.WebViewLoadedEventArgs>(x => This.DocumentLoaded += x, x => This.DocumentLoaded -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.WebViewLoadingEventArgs> DocumentLoading {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.WebViewLoadingEventArgs>, Eto.Forms.WebViewLoadingEventArgs>(x => This.DocumentLoading += x, x => This.DocumentLoading -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.WebViewNewWindowEventArgs> OpenNewWindow {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.WebViewNewWindowEventArgs>, Eto.Forms.WebViewNewWindowEventArgs>(x => This.OpenNewWindow += x, x => This.OpenNewWindow -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.WebViewTitleEventArgs> DocumentTitleChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.WebViewTitleEventArgs>, Eto.Forms.WebViewTitleEventArgs>(x => This.DocumentTitleChanged += x, x => This.DocumentTitleChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class FontDialogEvents
        : Eto.WidgetEvents
    {
        FontDialog This;

        public FontDialogEvents(FontDialog This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> FontChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.FontChanged += x, x => This.FontChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class IKeyboardInputSourceEvents
    {
        IKeyboardInputSource This;

        public IKeyboardInputSourceEvents(IKeyboardInputSource This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.KeyEventArgs>, Eto.Forms.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.KeyEventArgs>, Eto.Forms.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.TextInputEventArgs> TextInput {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.TextInputEventArgs>, Eto.Forms.TextInputEventArgs>(x => This.TextInput += x, x => This.TextInput -= x).Select(x => x.EventArgs); }
        }

    }
    public class IMouseInputSourceEvents
    {
        IMouseInputSource This;

        public IMouseInputSourceEvents(IMouseInputSource This)
        {
            this.This = This;
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseUp {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseUp += x, x => This.MouseUp -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseMove {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseMove += x, x => This.MouseMove -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseEnter {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseEnter += x, x => This.MouseEnter -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseLeave {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseLeave += x, x => This.MouseLeave -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseDown {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseDown += x, x => This.MouseDown -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseDoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseDoubleClick += x, x => This.MouseDoubleClick -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.MouseEventArgs> MouseWheel {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.MouseEventArgs>, Eto.Forms.MouseEventArgs>(x => This.MouseWheel += x, x => This.MouseWheel -= x).Select(x => x.EventArgs); }
        }

    }
    public class CheckMenuItemEvents
        : Eto.Forms.MenuItemEvents
    {
        CheckMenuItem This;

        public CheckMenuItemEvents(CheckMenuItem This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ContextMenuEvents
        : Eto.Forms.BindableWidgetEvents
    {
        ContextMenu This;

        public ContextMenuEvents(ContextMenu This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Opening {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Opening += x, x => This.Opening -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> Closed {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICommandItemEvents
    {
        ICommandItem This;

        public ICommandItemEvents(ICommandItem This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class MenuItemEvents
        : Eto.Forms.BindableWidgetEvents
    {
        MenuItem This;

        public MenuItemEvents(MenuItem This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> Validate {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Validate += x, x => This.Validate -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadioMenuItemEvents
        : Eto.Forms.MenuItemEvents
    {
        RadioMenuItem This;

        public RadioMenuItemEvents(RadioMenuItem This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class NotificationEvents
        : Eto.WidgetEvents
    {
        Notification This;

        public NotificationEvents(Notification This)
            : base(This)
        {
            this.This = This;
        }


        [Obsolete("Since 2.4, Use Application.NotificationActivated instead.")]
        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class PrintDocumentEvents
        : Eto.WidgetEvents
    {
        PrintDocument This;

        public PrintDocumentEvents(PrintDocument This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Printing {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Printing += x, x => This.Printing -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> Printed {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Printed += x, x => This.Printed -= x).Select(x => x.EventArgs); }
        }


        public IObservable<Eto.Forms.PrintPageEventArgs> PrintPage {
            get { return Observable.FromEventPattern<System.EventHandler<Eto.Forms.PrintPageEventArgs>, Eto.Forms.PrintPageEventArgs>(x => This.PrintPage += x, x => This.PrintPage -= x).Select(x => x.EventArgs); }
        }

    }
    public class CheckToolItemEvents
        : Eto.Forms.ToolItemEvents
    {
        CheckToolItem This;

        public CheckToolItemEvents(CheckToolItem This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadioToolItemEvents
        : Eto.Forms.ToolItemEvents
    {
        RadioToolItem This;

        public RadioToolItemEvents(RadioToolItem This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> CheckedChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CheckedChanged += x, x => This.CheckedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToolItemEvents
        : Eto.Forms.BindableWidgetEvents
    {
        ToolItem This;

        public ToolItemEvents(ToolItem This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class TrayIndicatorEvents
        : Eto.WidgetEvents
    {
        TrayIndicator This;

        public TrayIndicatorEvents(TrayIndicator This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class UITimerEvents
        : Eto.WidgetEvents
    {
        UITimer This;

        public UITimerEvents(UITimer This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Elapsed {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Elapsed += x, x => This.Elapsed -= x).Select(x => x.EventArgs); }
        }

    }
    public class WindowEvents
        : Eto.Forms.ControlEvents
    {
        Window This;

        public WindowEvents(Window This)
            : base(This)
        {
            this.This = This;
        }


        public IObservable<System.EventArgs> Closed {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.ComponentModel.CancelEventArgs> Closing {
            get { return Observable.FromEventPattern<System.EventHandler<System.ComponentModel.CancelEventArgs>, System.ComponentModel.CancelEventArgs>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> LocationChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.LocationChanged += x, x => This.LocationChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> OwnerChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.OwnerChanged += x, x => This.OwnerChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> WindowStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.WindowStateChanged += x, x => This.WindowStateChanged -= x).Select(x => x.EventArgs); }
        }


        public IObservable<System.EventArgs> LogicalPixelSizeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.LogicalPixelSizeChanged += x, x => This.LogicalPixelSizeChanged -= x).Select(x => x.EventArgs); }
        }

    }
}


#pragma warning restore 1591,0618,0105,0672
