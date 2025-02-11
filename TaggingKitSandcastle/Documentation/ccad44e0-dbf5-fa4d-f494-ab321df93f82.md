# Tag Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Interaction logic for Tag.xaml

Tag


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;System.Windows.Threading.DispatcherObject<br />&nbsp;&nbsp;&nbsp;&nbsp;System.Windows.DependencyObject<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;System.Windows.Media.Visual<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;System.Windows.UIElement<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;System.Windows.FrameworkElement<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;System.Windows.Controls.Control<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;System.Windows.Controls.ContentControl<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;System.Windows.Controls.UserControl<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;WetHatLab.OneNote.TaggingKit.common.ui.Tag<br />
**Namespace:**&nbsp;<a href="043a9407-ac38-b3ac-7348-a6090af495ad">WetHatLab.OneNote.TaggingKit.common.ui</a><br />**Assembly:**&nbsp;OneNoteTaggingKit (in OneNoteTaggingKit.dll) Version: 4.0.8059.31599

## Syntax

**C#**<br />
``` C#
public class Tag : UserControl, IComponentConnector
```

The Tag type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="53c931e9-50fa-ff98-87d6-e5e4d9447110">Tag</a></td><td>
Initialize a new instance of a tag control.</td></tr></table>&nbsp;
<a href="#tag-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ActualHeight</td><td>
Gets the rendered height of this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ActualWidth</td><td>
Gets the rendered width of this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>AllowDrop</td><td>
Gets or sets a value indicating whether this element can be used as the target of a drag-and-drop operation. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>AreAnyTouchesCaptured</td><td>
Gets a value that indicates whether at least one touch is captured to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>AreAnyTouchesCapturedWithin</td><td>
Gets a value that indicates whether at least one touch is captured to this element or to any child elements in its visual tree.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>AreAnyTouchesDirectlyOver</td><td>
Gets a value that indicates whether at least one touch is pressed over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>AreAnyTouchesOver</td><td>
Gets a value that indicates whether at least one touch is pressed over this element or any child elements in its visual tree.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Background</td><td>
Gets or sets a brush that describes the background of a control.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>BindingGroup</td><td>
Gets or sets the BindingGroup that is used for the element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>BitmapEffect</td><td> **Obsolete. **
Gets or sets a bitmap effect that applies directly to the rendered content for this element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>BitmapEffectInput</td><td> **Obsolete. **
Gets or sets an input source for the bitmap effect that applies directly to the rendered content for this element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>BorderBrush</td><td>
Gets or sets a brush that describes the border background of a control.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>BorderThickness</td><td>
Gets or sets the border thickness of a control.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>CacheMode</td><td>
Gets or sets a cached representation of the UIElement.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Clip</td><td>
Gets or sets the geometry used to define the outline of the contents of an element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ClipToBounds</td><td>
Gets or sets a value indicating whether to clip the content of this element (or content coming from the child elements of this element) to fit into the size of the containing element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>CommandBindings</td><td>
Gets a collection of CommandBinding objects associated with this element. A CommandBinding enables command handling for this element, and declares the linkage between a command, its events, and the handlers attached by this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Content</td><td>
Gets or sets the content of a ContentControl.
 (Inherited from ContentControl.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ContentStringFormat</td><td>
Gets or sets a composite string that specifies how to format the Content property if it is displayed as a string.
 (Inherited from ContentControl.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ContentTemplate</td><td>
Gets or sets the data template used to display the content of the ContentControl.
 (Inherited from ContentControl.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ContentTemplateSelector</td><td>
Gets or sets a template selector that enables an application writer to provide custom template-selection logic.
 (Inherited from ContentControl.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ContextMenu</td><td>
Gets or sets the context menu element that should appear whenever the context menu is requested through user interface (UI) from within this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Cursor</td><td>
Gets or sets the cursor that displays when the mouse pointer is over this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>DataContext</td><td>
Gets or sets the data context for an element when it participates in data binding.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>DefaultStyleKey</td><td>
Gets or sets the key to use to reference the style for this control, when theme styles are used or defined.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>DependencyObjectType</td><td>
Gets the DependencyObjectType that wraps the CLR type of this instance.&nbsp;
(Inherited from DependencyObject.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>DesiredSize</td><td>
Gets the size that this element computed during the measure pass of the layout process.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Dispatcher</td><td>
Gets the Dispatcher this DispatcherObject is associated with.
 (Inherited from DispatcherObject.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Effect</td><td>
Gets or sets the bitmap effect to apply to the UIElement. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>FlowDirection</td><td>
Gets or sets the direction that text and other user interface (UI) elements flow within any parent element that controls their layout.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Focusable</td><td>
Gets or sets a value that indicates whether the element can receive focus. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>FocusVisualStyle</td><td>
Gets or sets a property that enables customization of appearance, effects, or other style characteristics that will apply to this element when it captures keyboard focus.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>FontFamily</td><td>
Gets or sets the font family of the control.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>FontSize</td><td>
Gets or sets the font size.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>FontStretch</td><td>
Gets or sets the degree to which a font is condensed or expanded on the screen.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>FontStyle</td><td>
Gets or sets the font style.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>FontWeight</td><td>
Gets or sets the weight or thickness of the specified font.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ForceCursor</td><td>
Gets or sets a value that indicates whether this FrameworkElement should force the user interface (UI) to render the cursor as declared by the Cursor property.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Foreground</td><td>
Gets or sets a brush that describes the foreground color.
 (Inherited from Control.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>HandlesScrolling</td><td>
Gets a value that indicates whether a control supports scrolling.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>HasAnimatedProperties</td><td>
Gets a value indicating whether this element has any animated properties.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>HasContent</td><td>
Gets a value that indicates whether the ContentControl contains content.
 (Inherited from ContentControl.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>HasEffectiveKeyboardFocus</td><td>
Gets a value that indicates whether the UIElement has focus.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Height</td><td>
Gets or sets the suggested height of the element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>HorizontalAlignment</td><td>
Gets or sets the horizontal alignment characteristics applied to this element when it is composed within a parent element, such as a panel or items control.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>HorizontalContentAlignment</td><td>
Gets or sets the horizontal alignment of the control's content.
 (Inherited from Control.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>InheritanceBehavior</td><td>
Gets or sets the scope limits for property value inheritance, resource key lookup, and RelativeSource FindAncestor lookup.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>InputBindings</td><td>
Gets the collection of input bindings associated with this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>InputScope</td><td>
Gets or sets the context for input used by this FrameworkElement.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsArrangeValid</td><td>
Gets a value indicating whether the computed size and position of child elements in this element's layout are valid.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsEnabled</td><td>
Gets or sets a value indicating whether this element is enabled in the user interface (UI). This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>IsEnabledCore</td><td>
Gets a value that becomes the return value of IsEnabled in derived classes.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsFocused</td><td>
Gets a value that determines whether this element has logical focus. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsHitTestVisible</td><td>
Gets or sets a value that declares whether this element can possibly be returned as a hit test result from some portion of its rendered content. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsInitialized</td><td>
Gets a value that indicates whether this element has been initialized, either during processing by a XAML processor, or by explicitly having its EndInit() method called.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsInputMethodEnabled</td><td>
Gets a value indicating whether an input method system, such as an Input Method Editor (IME), is enabled for processing the input to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsKeyboardFocused</td><td>
Gets a value indicating whether this element has keyboard focus. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsKeyboardFocusWithin</td><td>
Gets a value indicating whether keyboard focus is anywhere within the element or its visual tree child elements. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsLoaded</td><td>
Gets a value that indicates whether this element has been loaded for presentation.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsManipulationEnabled</td><td>
Gets or sets a value that indicates whether manipulation events are enabled on this UIElement.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsMeasureValid</td><td>
Gets a value indicating whether the current size returned by layout measure is valid.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsMouseCaptured</td><td>
Gets a value indicating whether the mouse is captured to this element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsMouseCaptureWithin</td><td>
Gets a value that determines whether mouse capture is held by this element or by child elements in its visual tree. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsMouseDirectlyOver</td><td>
Gets a value that indicates whether the position of the mouse pointer corresponds to hit test results, which take element compositing into account. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsMouseOver</td><td>
Gets a value indicating whether the mouse pointer is located over this element (including child elements in the visual tree). This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsSealed</td><td>
Gets a value that indicates whether this instance is currently sealed (read-only).
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsStylusCaptured</td><td>
Gets a value indicating whether the stylus is captured by this element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsStylusCaptureWithin</td><td>
Gets a value that determines whether stylus capture is held by this element, or an element within the element bounds and its visual tree. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsStylusDirectlyOver</td><td>
Gets a value that indicates whether the stylus position corresponds to hit test results, which take element compositing into account. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsStylusOver</td><td>
Gets a value indicating whether the stylus cursor is located over this element (including visual child elements). This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsTabStop</td><td>
Gets or sets a value that indicates whether a control is included in tab navigation.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>IsVisible</td><td>
Gets a value indicating whether this element is visible in the user interface (UI). This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Language</td><td>
Gets or sets localization/globalization language information that applies to an element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>LayoutTransform</td><td>
Gets or sets a graphics transformation that should apply to this element when layout is performed.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>LogicalChildren</td><td>
Gets an enumerator to the content control's logical child elements.
 (Inherited from ContentControl.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Margin</td><td>
Gets or sets the outer margin of an element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>MaxHeight</td><td>
Gets or sets the maximum height constraint of the element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>MaxWidth</td><td>
Gets or sets the maximum width constraint of the element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>MinHeight</td><td>
Gets or sets the minimum height constraint of the element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>MinWidth</td><td>
Gets or sets the minimum width constraint of the element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Name</td><td>
Gets or sets the identifying name of the element. The name provides a reference so that code-behind, such as event handler code, can refer to a markup element after it is constructed during processing by a XAML processor.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Opacity</td><td>
Gets or sets the opacity factor applied to the entire UIElement when it is rendered in the user interface (UI). This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>OpacityMask</td><td>
Gets or sets an opacity mask, as a Brush implementation that is applied to any alpha-channel masking for the rendered content of this element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>OverridesDefaultStyle</td><td>
Gets or sets a value that indicates whether this element incorporates style properties from theme styles.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Padding</td><td>
Gets or sets the padding inside a control.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Parent</td><td>
Gets the logical parent element of this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>PersistId</td><td> **Obsolete. **
Gets a value that uniquely identifies this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>RenderSize</td><td>
Gets (or sets) the final render size of this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>RenderTransform</td><td>
Gets or sets transform information that affects the rendering position of this element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>RenderTransformOrigin</td><td>
Gets or sets the center point of any possible render transform declared by RenderTransform, relative to the bounds of the element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Resources</td><td>
Gets or sets the locally-defined resource dictionary.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>SnapsToDevicePixels</td><td>
Gets or sets a value that determines whether rendering for this element should use device-specific pixel settings during rendering. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Style</td><td>
Gets or sets the style used by this element when it is rendered.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>StylusPlugIns</td><td>
Gets a collection of all stylus plug-in (customization) objects associated with this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>TabIndex</td><td>
Gets or sets a value that determines the order in which elements receive focus when the user navigates through controls by using the TAB key.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Tag</td><td>
Gets or sets an arbitrary object value that can be used to store custom information about this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Template</td><td>
Gets or sets a control template.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>TemplatedParent</td><td>
Gets a reference to the template parent of this element. This property is not relevant if the element was not created through a template.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>ToolTip</td><td>
Gets or sets the tool-tip object that is displayed for this element in the user interface (UI).
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>TouchesCaptured</td><td>
Gets all touch devices that are captured to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>TouchesCapturedWithin</td><td>
Gets all touch devices that are captured to this element or any child elements in its visual tree.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>TouchesDirectlyOver</td><td>
Gets all touch devices that are over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>TouchesOver</td><td>
Gets all touch devices that are over this element or any child elements in its visual tree.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Triggers</td><td>
Gets the collection of triggers established directly on this element, or in child elements.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Uid</td><td>
Gets or sets the unique identifier (for localization) for this element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>UseLayoutRounding</td><td>
Gets or sets a value that indicates whether layout rounding should be applied to this element's size and position during layout.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>VerticalAlignment</td><td>
Gets or sets the vertical alignment characteristics applied to this element when it is composed within a parent element such as a panel or items control.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>VerticalContentAlignment</td><td>
Gets or sets the vertical alignment of the control's content.
 (Inherited from Control.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Visibility</td><td>
Gets or sets the user interface (UI) visibility of this element. This is a dependency property.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualBitmapEffect</td><td> **Obsolete. **
Gets or sets the BitmapEffect value for the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualBitmapEffectInput</td><td> **Obsolete. **
Gets or sets the BitmapEffectInput value for the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualBitmapScalingMode</td><td>
Gets or sets the BitmapScalingMode for the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualCacheMode</td><td>
Gets or sets a cached representation of the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualChildrenCount</td><td>
Gets the number of visual child elements within this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualClearTypeHint</td><td>
Gets or sets the ClearTypeHint that determines how ClearType is rendered in the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualClip</td><td>
Gets or sets the clip region of the Visual as a Geometry value.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualEdgeMode</td><td>
Gets or sets the edge mode of the Visual as an EdgeMode value.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualEffect</td><td>
Gets or sets the bitmap effect to apply to the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualOffset</td><td>
Gets or sets the offset value of the visual object.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualOpacity</td><td>
Gets or sets the opacity of the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualOpacityMask</td><td>
Gets or sets the Brush value that represents the opacity mask of the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualParent</td><td>
Gets the visual tree parent of the visual object.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualScrollableAreaClip</td><td>
Gets or sets a clipped scrollable area for the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualTextHintingMode</td><td>
Gets or sets the TextHintingMode of the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualTextRenderingMode</td><td>
Gets or sets the TextRenderingMode of the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualTransform</td><td>
Gets or sets the Transform value for the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualXSnappingGuidelines</td><td>
Gets or sets the x-coordinate (vertical) guideline collection.
 (Inherited from Visual.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td>VisualYSnappingGuidelines</td><td>
Gets or sets the y-coordinate (horizontal) guideline collection.
 (Inherited from Visual.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td>Width</td><td>
Gets or sets the width of the element.
 (Inherited from FrameworkElement.)</td></tr></table>&nbsp;
<a href="#tag-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>AddChild</td><td>
Adds a specified object as the child of a ContentControl.
 (Inherited from ContentControl.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>AddHandler(RoutedEvent, Delegate)</td><td>
Adds a routed event handler for a specified routed event, adding the handler to the handler collection on the current element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>AddHandler(RoutedEvent, Delegate, Boolean)</td><td>
Adds a routed event handler for a specified routed event, adding the handler to the handler collection on the current element. Specify *handledEventsToo* as `true` (`True` in Visual Basic) to have the provided handler be invoked for routed event that had already been marked as handled by another element along the event route.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>AddLogicalChild</td><td>
Adds the provided object to the logical tree of this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>AddText</td><td>
Adds a specified text string to a ContentControl.
 (Inherited from ContentControl.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>AddToEventRoute</td><td>
Adds handlers to the specified EventRoute for the current UIElement event handler collection.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>AddVisualChild</td><td>
Defines the parent-child relationship between two visuals.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ApplyAnimationClock(DependencyProperty, AnimationClock)</td><td>
Applies an animation to a specified dependency property on this element. Any existing animations are stopped and replaced with the new animation.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ApplyAnimationClock(DependencyProperty, AnimationClock, HandoffBehavior)</td><td>
Applies an animation to a specified dependency property on this element, with the ability to specify what happens if the property already has a running animation.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ApplyTemplate</td><td>
Builds the current template's visual tree if necessary, and returns a value that indicates whether the visual tree was rebuilt by this call.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Arrange</td><td>
Positions child elements and determines a size for a UIElement. Parent elements call this method from their ArrangeCore(Rect) implementation (or a WPF framework-level equivalent) to form a recursive layout update. This method constitutes the second pass of a layout update.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>ArrangeCore</td><td>
Implements ArrangeCore(Rect) (defined as virtual in UIElement) and seals the implementation.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>ArrangeOverride</td><td>
Called to arrange and size the content of a Control object.
 (Inherited from Control.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>BeginAnimation(DependencyProperty, AnimationTimeline)</td><td>
Starts an animation for a specified animated property on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>BeginAnimation(DependencyProperty, AnimationTimeline, HandoffBehavior)</td><td>
Starts a specific animation for a specified animated property on this element, with the option of specifying what happens if the property already has a running animation.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>BeginInit</td><td>
Starts the initialization process for this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>BeginStoryboard(Storyboard)</td><td>
Begins the sequence of actions that are contained in the provided storyboard.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>BeginStoryboard(Storyboard, HandoffBehavior)</td><td>
Begins the sequence of actions contained in the provided storyboard, with options specified for what should happen if the property is already animated.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>BeginStoryboard(Storyboard, HandoffBehavior, Boolean)</td><td>
Begins the sequence of actions contained in the provided storyboard, with specified state for control of the animation after it is started.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>BringIntoView()</td><td>
Attempts to bring this element into view, within any scrollable regions it is contained within.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>BringIntoView(Rect)</td><td>
Attempts to bring the provided region size of this element into view, within any scrollable regions it is contained within.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>CaptureMouse</td><td>
Attempts to force capture of the mouse to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>CaptureStylus</td><td>
Attempts to force capture of the stylus to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>CaptureTouch</td><td>
Attempts to force capture of a touch to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>CheckAccess</td><td>
Determines whether the calling thread has access to this DispatcherObject.
 (Inherited from DispatcherObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ClearValue(DependencyProperty)</td><td>
Clears the local value of a property. The property to be cleared is specified by a DependencyProperty identifier.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ClearValue(DependencyPropertyKey)</td><td>
Clears the local value of a read-only property. The property to be cleared is specified by a DependencyPropertyKey.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>CoerceValue</td><td>
Coerces the value of the specified dependency property. This is accomplished by invoking any CoerceValueCallback function specified in property metadata for the dependency property as it exists on the calling DependencyObject.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>EndInit</td><td>
Indicates that the initialization process for the element is complete.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td>
Determines whether a provided DependencyObject is equivalent to the current DependencyObject.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>FindCommonVisualAncestor</td><td>
Returns the common ancestor of two visual objects.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>FindName</td><td>
Finds an element that has the provided identifier name.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>FindResource</td><td>
Searches for a resource with the specified key, and throws an exception if the requested resource is not found.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Focus</td><td>
Attempts to set focus to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetAnimationBaseValue</td><td>
Returns the base property value for the specified property on this element, disregarding any possible animated value from a running or stopped animation.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetBindingExpression</td><td>
Returns the BindingExpression that represents the binding on the specified property.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td>
Gets a hash code for this DependencyObject.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>GetLayoutClip</td><td>
Returns a geometry for a clipping mask. The mask applies if the layout system attempts to arrange an element that is larger than the available display space.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetLocalValueEnumerator</td><td>
Creates a specialized enumerator for determining which dependency properties have locally set values on this DependencyObject.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>GetTemplateChild</td><td>
Returns the named element in the visual tree of an instantiated ControlTemplate.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td>
Gets the Type of the current instance.
 (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>GetUIParentCore</td><td>
Returns an alternative logical parent for this element if there is no visual parent.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetValue</td><td>
Returns the current effective value of a dependency property on this instance of a DependencyObject.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>GetVisualChild</td><td>
Overrides GetVisualChild(Int32), and returns a child at the specified index from a collection of child elements.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>HitTestCore(PointHitTestParameters)</td><td>
Implements HitTestCore(PointHitTestParameters) to supply base element hit testing behavior (returning HitTestResult).
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>HitTestCore(GeometryHitTestParameters)</td><td>
Implements HitTestCore(GeometryHitTestParameters) to supply base element hit testing behavior (returning GeometryHitTestResult).
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="449fab2f-e652-daf4-9066-1dcdc699a5c5">InitializeComponent</a></td><td>
InitializeComponent</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>InputHitTest</td><td>
Returns the input element within the current element that is at the specified coordinates, relative to the current element's origin.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>InvalidateArrange</td><td>
Invalidates the arrange state (layout) for the element. After the invalidation, the element will have its layout updated, which will occur asynchronously unless subsequently forced by UpdateLayout().
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>InvalidateMeasure</td><td>
Invalidates the measurement state (layout) for the element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>InvalidateProperty</td><td>
Re-evaluates the effective value for the specified dependency property
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>InvalidateVisual</td><td>
Invalidates the rendering of the element, and forces a complete new layout pass. OnRender(DrawingContext) is called after the layout cycle is completed.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>IsAncestorOf</td><td>
Determines whether the visual object is an ancestor of the descendant visual object.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>IsDescendantOf</td><td>
Determines whether the visual object is a descendant of the ancestor visual object.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Measure</td><td>
Updates the DesiredSize of a UIElement. Parent elements call this method from their own MeasureCore(Size) implementations to form a recursive layout update. Calling this method constitutes the first pass (the "Measure" pass) of a layout update.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MeasureCore</td><td>
Implements basic measure-pass layout system behavior for FrameworkElement.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MeasureOverride</td><td>
Called to remeasure a control.
 (Inherited from Control.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td>
Creates a shallow copy of the current Object.
 (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>MoveFocus</td><td>
Moves the keyboard focus away from this element and to another element in a provided traversal direction.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnAccessKey</td><td>
Provides class handling for when an access key that is meaningful for this element is invoked.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>OnApplyTemplate</td><td>
When overridden in a derived class, is invoked whenever application code or internal processes call ApplyTemplate().
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnChildDesiredSizeChanged</td><td>
Supports layout behavior when a child element is resized.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnContentChanged</td><td>
Called when the Content property changes.
 (Inherited from ContentControl.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnContentStringFormatChanged</td><td>
Occurs when the ContentStringFormat property changes.
 (Inherited from ContentControl.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnContentTemplateChanged</td><td>
Called when the ContentTemplate property changes.
 (Inherited from ContentControl.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnContentTemplateSelectorChanged</td><td>
Called when the ContentTemplateSelector property changes.
 (Inherited from ContentControl.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnContextMenuClosing</td><td>
Invoked whenever an unhandled ContextMenuClosing routed event reaches this class in its route. Implement this method to add class handling for this event.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnContextMenuOpening</td><td>
Invoked whenever an unhandled ContextMenuOpening routed event reaches this class in its route. Implement this method to add class handling for this event.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnCreateAutomationPeer</td><td>
Creates and returns an AutomationPeer for this UserControl.
 (Inherited from UserControl.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnDragEnter</td><td>
Invoked when an unhandled DragEnter attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnDragLeave</td><td>
Invoked when an unhandled DragLeave attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnDragOver</td><td>
Invoked when an unhandled DragOver attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnDrop</td><td>
Invoked when an unhandled DragEnter attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnGiveFeedback</td><td>
Invoked when an unhandled GiveFeedback attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnGotFocus</td><td>
Invoked whenever an unhandled GotFocus event reaches this element in its route.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnGotKeyboardFocus</td><td>
Invoked when an unhandled GotKeyboardFocus attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnGotMouseCapture</td><td>
Invoked when an unhandled GotMouseCapture attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnGotStylusCapture</td><td>
Invoked when an unhandled GotStylusCapture attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnGotTouchCapture</td><td>
Provides class handling for the GotTouchCapture routed event that occurs when a touch is captured to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnInitialized</td><td>
Raises the Initialized event. This method is invoked whenever IsInitialized is set to `true `internally.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnIsKeyboardFocusedChanged</td><td>
Invoked when an unhandled IsKeyboardFocusedChanged event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnIsKeyboardFocusWithinChanged</td><td>
Invoked just before the IsKeyboardFocusWithinChanged event is raised by this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnIsMouseCapturedChanged</td><td>
Invoked when an unhandled IsMouseCapturedChanged event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnIsMouseCaptureWithinChanged</td><td>
Invoked when an unhandled IsMouseCaptureWithinChanged event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnIsMouseDirectlyOverChanged</td><td>
Invoked when an unhandled IsMouseDirectlyOverChanged event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnIsStylusCapturedChanged</td><td>
Invoked when an unhandled IsStylusCapturedChanged event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnIsStylusCaptureWithinChanged</td><td>
Invoked when an unhandled IsStylusCaptureWithinChanged event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnIsStylusDirectlyOverChanged</td><td>
Invoked when an unhandled IsStylusDirectlyOverChanged event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnKeyDown</td><td>
Invoked when an unhandled KeyDown attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnKeyUp</td><td>
Invoked when an unhandled KeyUp attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnLostFocus</td><td>
Raises the LostFocus routed event by using the event data that is provided.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnLostKeyboardFocus</td><td>
Invoked when an unhandled LostKeyboardFocus attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnLostMouseCapture</td><td>
Invoked when an unhandled LostMouseCapture attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnLostStylusCapture</td><td>
Invoked when an unhandled LostStylusCapture attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnLostTouchCapture</td><td>
Provides class handling for the LostTouchCapture routed event that occurs when this element loses a touch capture.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnManipulationBoundaryFeedback</td><td>
Called when the ManipulationBoundaryFeedback event occurs.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnManipulationCompleted</td><td>
Called when the ManipulationCompleted event occurs.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnManipulationDelta</td><td>
Called when the ManipulationDelta event occurs.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnManipulationInertiaStarting</td><td>
Called when the ManipulationInertiaStarting event occurs.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnManipulationStarted</td><td>
Called when the ManipulationStarted event occurs.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnManipulationStarting</td><td>
Provides class handling for the ManipulationStarting routed event that occurs when the manipulation processor is first created.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseDoubleClick</td><td>
Raises the MouseDoubleClick routed event.
 (Inherited from Control.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseDown</td><td>
Invoked when an unhandled MouseDown attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseEnter</td><td>
Invoked when an unhandled MouseEnter attached event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseLeave</td><td>
Invoked when an unhandled MouseLeave attached event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseLeftButtonDown</td><td>
Invoked when an unhandled MouseLeftButtonDown routed event is raised on this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseLeftButtonUp</td><td>
Invoked when an unhandled MouseLeftButtonUp routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseMove</td><td>
Invoked when an unhandled MouseMove attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseRightButtonDown</td><td>
Invoked when an unhandled MouseRightButtonDown routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseRightButtonUp</td><td>
Invoked when an unhandled MouseRightButtonUp routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseUp</td><td>
Invoked when an unhandled MouseUp routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnMouseWheel</td><td>
Invoked when an unhandled MouseWheel attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewDragEnter</td><td>
Invoked when an unhandled PreviewDragEnter attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewDragLeave</td><td>
Invoked when an unhandled PreviewDragLeave attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewDragOver</td><td>
Invoked when an unhandled PreviewDragOver attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewDrop</td><td>
Invoked when an unhandled PreviewDrop attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewGiveFeedback</td><td>
Invoked when an unhandled PreviewGiveFeedback attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewGotKeyboardFocus</td><td>
Invoked when an unhandled PreviewGotKeyboardFocus attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewKeyDown</td><td>
Invoked when an unhandled PreviewKeyDown attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewKeyUp</td><td>
Invoked when an unhandled PreviewKeyUp attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewLostKeyboardFocus</td><td>
Invoked when an unhandled PreviewKeyDown attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseDoubleClick</td><td>
Raises the PreviewMouseDoubleClick routed event.
 (Inherited from Control.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseDown</td><td>
Invoked when an unhandled PreviewMouseDown attached routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseLeftButtonDown</td><td>
Invoked when an unhandled PreviewMouseLeftButtonDown routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseLeftButtonUp</td><td>
Invoked when an unhandled PreviewMouseLeftButtonUp routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseMove</td><td>
Invoked when an unhandled PreviewMouseMove attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseRightButtonDown</td><td>
Invoked when an unhandled PreviewMouseRightButtonDown routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseRightButtonUp</td><td>
Invoked when an unhandled PreviewMouseRightButtonUp routed event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseUp</td><td>
Invoked when an unhandled PreviewMouseUp attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewMouseWheel</td><td>
Invoked when an unhandled PreviewMouseWheel attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewQueryContinueDrag</td><td>
Invoked when an unhandled PreviewQueryContinueDrag attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusButtonDown</td><td>
Invoked when an unhandled PreviewStylusButtonDown attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusButtonUp</td><td>
Invoked when an unhandled PreviewStylusButtonUp attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusDown</td><td>
Invoked when an unhandled PreviewStylusDown attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusInAirMove</td><td>
Invoked when an unhandled PreviewStylusInAirMove attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusInRange</td><td>
Invoked when an unhandled PreviewStylusInRange attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusMove</td><td>
Invoked when an unhandled PreviewStylusMove attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusOutOfRange</td><td>
Invoked when an unhandled PreviewStylusOutOfRange attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusSystemGesture</td><td>
Invoked when an unhandled PreviewStylusSystemGesture attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewStylusUp</td><td>
Invoked when an unhandled PreviewStylusUp attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewTextInput</td><td>
Invoked when an unhandled PreviewTextInput attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewTouchDown</td><td>
Provides class handling for the PreviewTouchDown routed event that occurs when a touch presses this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewTouchMove</td><td>
Provides class handling for the PreviewTouchMove routed event that occurs when a touch moves while inside this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPreviewTouchUp</td><td>
Provides class handling for the PreviewTouchUp routed event that occurs when a touch is released inside this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnPropertyChanged</td><td>
Invoked whenever the effective value of any dependency property on this FrameworkElement has been updated. The specific dependency property that changed is reported in the arguments parameter. Overrides OnPropertyChanged(DependencyPropertyChangedEventArgs).
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnQueryContinueDrag</td><td>
Invoked when an unhandled QueryContinueDrag attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnQueryCursor</td><td>
Invoked when an unhandled QueryCursor attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnRender</td><td>
When overridden in a derived class, participates in rendering operations that are directed by the layout system. The rendering instructions for this element are not used directly when this method is invoked, and are instead preserved for later asynchronous use by layout and drawing.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnRenderSizeChanged</td><td>
Raises the SizeChanged event, using the specified information as part of the eventual event data.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStyleChanged</td><td>
Invoked when the style in use on this element changes, which will invalidate the layout.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusButtonDown</td><td>
Invoked when an unhandled StylusButtonDown attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusButtonUp</td><td>
Invoked when an unhandled StylusButtonUp attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusDown</td><td>
Invoked when an unhandled StylusDown attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusEnter</td><td>
Invoked when an unhandled StylusEnter attached event is raised by this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusInAirMove</td><td>
Invoked when an unhandled StylusInAirMove attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusInRange</td><td>
Invoked when an unhandled StylusInRange attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusLeave</td><td>
Invoked when an unhandled StylusLeave attached event is raised by this element. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusMove</td><td>
Invoked when an unhandled StylusMove attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusOutOfRange</td><td>
Invoked when an unhandled StylusOutOfRange attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusSystemGesture</td><td>
Invoked when an unhandled StylusSystemGesture attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnStylusUp</td><td>
Invoked when an unhandled StylusUp attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnTemplateChanged</td><td>
Called whenever the control's template changes.
 (Inherited from Control.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnTextInput</td><td>
Invoked when an unhandled TextInput attached event reaches an element in its route that is derived from this class. Implement this method to add class handling for this event.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnToolTipClosing</td><td>
Invoked whenever an unhandled ToolTipClosing routed event reaches this class in its route. Implement this method to add class handling for this event.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnToolTipOpening</td><td>
Invoked whenever the ToolTipOpening routed event reaches this class in its route. Implement this method to add class handling for this event.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnTouchDown</td><td>
Provides class handling for the TouchDown routed event that occurs when a touch presses inside this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnTouchEnter</td><td>
Provides class handling for the TouchEnter routed event that occurs when a touch moves from outside to inside the bounds of this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnTouchLeave</td><td>
Provides class handling for the TouchLeave routed event that occurs when a touch moves from inside to outside the bounds of this UIElement.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnTouchMove</td><td>
Provides class handling for the TouchMove routed event that occurs when a touch moves while inside this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnTouchUp</td><td>
Provides class handling for the TouchUp routed event that occurs when a touch is released inside this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnVisualChildrenChanged</td><td>
Called when the VisualCollection of the visual object is modified.
 (Inherited from Visual.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>OnVisualParentChanged</td><td>
Invoked when the parent of this element in the visual tree is changed. Overrides OnVisualParentChanged(DependencyObject).
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>ParentLayoutInvalidated</td><td>
Supports incremental layout implementations in specialized subclasses of FrameworkElement. ParentLayoutInvalidated(UIElement) is invoked when a child element has invalidated a property that is marked in metadata as affecting the parent's measure or arrange passes during layout.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>PointFromScreen</td><td>
Converts a Point in screen coordinates into a Point that represents the current coordinate system of the Visual.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>PointToScreen</td><td>
Converts a Point that represents the current coordinate system of the Visual into a Point in screen coordinates.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>PredictFocus</td><td>
Determines the next element that would receive focus relative to this element for a provided focus movement direction, but does not actually move the focus.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>RaiseEvent</td><td>
Raises a specific routed event. The RoutedEvent to be raised is identified within the RoutedEventArgs instance that is provided (as the RoutedEvent property of that event data).
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ReadLocalValue</td><td>
Returns the local value of a dependency property, if it exists.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>RegisterName</td><td>
Provides an accessor that simplifies access to the NameScope registration method.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ReleaseAllTouchCaptures</td><td>
Releases all captured touch devices from this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ReleaseMouseCapture</td><td>
Releases the mouse capture, if this element held the capture.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ReleaseStylusCapture</td><td>
Releases the stylus device capture, if this element held the capture.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ReleaseTouchCapture</td><td>
Attempts to release the specified touch device from this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>RemoveHandler</td><td>
Removes the specified routed event handler from this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>RemoveLogicalChild</td><td>
Removes the provided object from this element's logical tree. FrameworkElement updates the affected logical tree parent pointers to keep in sync with this deletion.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>RemoveVisualChild</td><td>
Removes the parent-child relationship between two visuals.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>SetBinding(DependencyProperty, BindingBase)</td><td>
Attaches a binding to this element, based on the provided binding object.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>SetBinding(DependencyProperty, String)</td><td>
Attaches a binding to this element, based on the provided source property name as a path qualification to the data source.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>SetCurrentValue</td><td>
Sets the value of a dependency property without changing its value source.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>SetResourceReference</td><td>
Searches for a resource with the specified name and sets up a resource reference to it for the specified property.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>SetValue(DependencyProperty, Object)</td><td>
Sets the local value of a dependency property, specified by its dependency property identifier.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>SetValue(DependencyPropertyKey, Object)</td><td>
Sets the local value of a read-only dependency property, specified by the DependencyPropertyKey identifier of the dependency property.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ShouldSerializeCommandBindings</td><td>
Returns whether serialization processes should serialize the contents of the CommandBindings property on instances of this class.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ShouldSerializeContent</td><td>
Indicates whether the Content property should be persisted.
 (Inherited from ContentControl.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ShouldSerializeInputBindings</td><td>
Returns whether serialization processes should serialize the contents of the InputBindings property on instances of this class.
 (Inherited from UIElement.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>ShouldSerializeProperty</td><td>
Returns a value that indicates whether serialization processes should serialize the value for the provided dependency property.
 (Inherited from DependencyObject.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ShouldSerializeResources</td><td>
Returns whether serialization processes should serialize the contents of the Resources property.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ShouldSerializeStyle</td><td>
Returns whether serialization processes should serialize the contents of the Style property.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ShouldSerializeTriggers</td><td>
Returns whether serialization processes should serialize the contents of the Triggers property.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ToString</td><td>
Returns the string representation of a Control object.
 (Inherited from Control.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>TransformToAncestor(Visual)</td><td>
Returns a transform that can be used to transform coordinates from the Visual to the specified Visual ancestor of the visual object.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>TransformToAncestor(Visual3D)</td><td>
Returns a transform that can be used to transform coordinates from the Visual to the specified Visual3D ancestor of the visual object.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>TransformToDescendant</td><td>
Returns a transform that can be used to transform coordinates from the Visual to the specified visual object descendant.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>TransformToVisual</td><td>
Returns a transform that can be used to transform coordinates from the Visual to the specified visual object.
 (Inherited from Visual.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>TranslatePoint</td><td>
Translates a point relative to this element to coordinates that are relative to the specified element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>TryFindResource</td><td>
Searches for a resource with the specified key, and returns that resource if found.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>UnregisterName</td><td>
Simplifies access to the NameScope de-registration method.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>UpdateDefaultStyle</td><td>
Reapplies the default style to the current FrameworkElement.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>UpdateLayout</td><td>
Ensures that all visual child elements of this element are properly updated for layout.
 (Inherited from UIElement.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>VerifyAccess</td><td>
Enforces that the calling thread has access to this DispatcherObject.
 (Inherited from DispatcherObject.)</td></tr></table>&nbsp;
<a href="#tag-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ContextMenuClosing</td><td>
Occurs just before any context menu on the element is closed.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ContextMenuOpening</td><td>
Occurs when any context menu on the element is opened.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>DataContextChanged</td><td>
Occurs when the data context for this element changes.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>DragEnter</td><td>
Occurs when the input system reports an underlying drag event with this element as the drag target.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>DragLeave</td><td>
Occurs when the input system reports an underlying drag event with this element as the drag origin.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>DragOver</td><td>
Occurs when the input system reports an underlying drag event with this element as the potential drop target.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>Drop</td><td>
Occurs when the input system reports an underlying drop event with this element as the drop target.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>FocusableChanged</td><td>
Occurs when the value of the Focusable property changes.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>GiveFeedback</td><td>
Occurs when the input system reports an underlying drag-and-drop event that involves this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>GotFocus</td><td>
Occurs when this element gets logical focus.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>GotKeyboardFocus</td><td>
Occurs when the keyboard is focused on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>GotMouseCapture</td><td>
Occurs when this element captures the mouse.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>GotStylusCapture</td><td>
Occurs when this element captures the stylus.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>GotTouchCapture</td><td>
Occurs when a touch is captured to this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>Initialized</td><td>
Occurs when this FrameworkElement is initialized. This event coincides with cases where the value of the IsInitialized property changes from `false` (`False` in Visual Basic) (or undefined) to `true` (`True` in Visual Basic).
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsEnabledChanged</td><td>
Occurs when the value of the IsEnabled property on this element changes.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsHitTestVisibleChanged</td><td>
Occurs when the value of the IsHitTestVisible dependency property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsKeyboardFocusedChanged</td><td>
Occurs when the value of the IsKeyboardFocused property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsKeyboardFocusWithinChanged</td><td>
Occurs when the value of the IsKeyboardFocusWithinChanged property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsMouseCapturedChanged</td><td>
Occurs when the value of the IsMouseCaptured property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsMouseCaptureWithinChanged</td><td>
Occurs when the value of the IsMouseCaptureWithinProperty changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsMouseDirectlyOverChanged</td><td>
Occurs when the value of the IsMouseDirectlyOver property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsStylusCapturedChanged</td><td>
Occurs when the value of the IsStylusCaptured property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsStylusCaptureWithinChanged</td><td>
Occurs when the value of the IsStylusCaptureWithin property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsStylusDirectlyOverChanged</td><td>
Occurs when the value of the IsStylusDirectlyOver property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>IsVisibleChanged</td><td>
Occurs when the value of the IsVisible property changes on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>KeyDown</td><td>
Occurs when a key is pressed while focus is on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>KeyUp</td><td>
Occurs when a key is released while focus is on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>LayoutUpdated</td><td>
Occurs when the layout of the various visual elements associated with the current Dispatcher changes.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>Loaded</td><td>
Occurs when the element is laid out, rendered, and ready for interaction.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>LostFocus</td><td>
Occurs when this element loses logical focus.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>LostKeyboardFocus</td><td>
Occurs when the keyboard is no longer focused on this element,.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>LostMouseCapture</td><td>
Occurs when this element loses mouse capture.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>LostStylusCapture</td><td>
Occurs when this element loses stylus capture.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>LostTouchCapture</td><td>
Occurs when this element loses a touch capture.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ManipulationBoundaryFeedback</td><td>
Occurs when the manipulation encounters a boundary.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ManipulationCompleted</td><td>
Occurs when a manipulation and inertia on the UIElement object is complete.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ManipulationDelta</td><td>
Occurs when the input device changes position during a manipulation.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ManipulationInertiaStarting</td><td>
Occurs when the input device loses contact with the UIElement object during a manipulation and inertia begins.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ManipulationStarted</td><td>
Occurs when an input device begins a manipulation on the UIElement object.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ManipulationStarting</td><td>
Occurs when the manipulation processor is first created.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseDoubleClick</td><td>
Occurs when a mouse button is clicked two or more times.
 (Inherited from Control.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseDown</td><td>
Occurs when any mouse button is pressed while the pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseEnter</td><td>
Occurs when the mouse pointer enters the bounds of this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseLeave</td><td>
Occurs when the mouse pointer leaves the bounds of this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseLeftButtonDown</td><td>
Occurs when the left mouse button is pressed while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseLeftButtonUp</td><td>
Occurs when the left mouse button is released while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseMove</td><td>
Occurs when the mouse pointer moves while over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseRightButtonDown</td><td>
Occurs when the right mouse button is pressed while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseRightButtonUp</td><td>
Occurs when the right mouse button is released while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseUp</td><td>
Occurs when any mouse button is released over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>MouseWheel</td><td>
Occurs when the user rotates the mouse wheel while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewDragEnter</td><td>
Occurs when the input system reports an underlying drag event with this element as the drag target.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewDragLeave</td><td>
Occurs when the input system reports an underlying drag event with this element as the drag origin.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewDragOver</td><td>
Occurs when the input system reports an underlying drag event with this element as the potential drop target.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewDrop</td><td>
Occurs when the input system reports an underlying drop event with this element as the drop target.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewGiveFeedback</td><td>
Occurs when a drag-and-drop operation is started.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewGotKeyboardFocus</td><td>
Occurs when the keyboard is focused on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewKeyDown</td><td>
Occurs when a key is pressed while focus is on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewKeyUp</td><td>
Occurs when a key is released while focus is on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewLostKeyboardFocus</td><td>
Occurs when the keyboard is no longer focused on this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseDoubleClick</td><td>
Occurs when a user clicks the mouse button two or more times.
 (Inherited from Control.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseDown</td><td>
Occurs when any mouse button is pressed while the pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseLeftButtonDown</td><td>
Occurs when the left mouse button is pressed while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseLeftButtonUp</td><td>
Occurs when the left mouse button is released while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseMove</td><td>
Occurs when the mouse pointer moves while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseRightButtonDown</td><td>
Occurs when the right mouse button is pressed while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseRightButtonUp</td><td>
Occurs when the right mouse button is released while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseUp</td><td>
Occurs when any mouse button is released while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewMouseWheel</td><td>
Occurs when the user rotates the mouse wheel while the mouse pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewQueryContinueDrag</td><td>
Occurs when there is a change in the keyboard or mouse button state during a drag-and-drop operation.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusButtonDown</td><td>
Occurs when the stylus button is pressed while the pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusButtonUp</td><td>
Occurs when the stylus button is released while the pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusDown</td><td>
Occurs when the stylus touches the digitizer while it is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusInAirMove</td><td>
Occurs when the stylus moves over an element without actually touching the digitizer.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusInRange</td><td>
Occurs when the stylus is close enough to the digitizer to be detected, while over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusMove</td><td>
Occurs when the stylus moves while over the element. The stylus must move while being detected by the digitizer to raise this event, otherwise, PreviewStylusInAirMove is raised instead.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusOutOfRange</td><td>
Occurs when the stylus is too far from the digitizer to be detected.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusSystemGesture</td><td>
Occurs when a user performs one of several stylus gestures.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewStylusUp</td><td>
Occurs when the user raises the stylus off the digitizer while the stylus is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewTextInput</td><td>
Occurs when this element gets text in a device-independent manner.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewTouchDown</td><td>
Occurs when a finger touches the screen while the finger is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewTouchMove</td><td>
Occurs when a finger moves on the screen while the finger is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>PreviewTouchUp</td><td>
Occurs when a finger is raised off of the screen while the finger is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>QueryContinueDrag</td><td>
Occurs when there is a change in the keyboard or mouse button state during a drag-and-drop operation.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>QueryCursor</td><td>
Occurs when the cursor is requested to display. This event is raised on an element each time that the mouse pointer moves to a new location, which means the cursor object might need to be changed based on its new position.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>RequestBringIntoView</td><td>
Occurs when BringIntoView(Rect) is called on this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>SizeChanged</td><td>
Occurs when either the ActualHeight or the ActualWidth properties change value on this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>SourceUpdated</td><td>
Occurs when the source value changes for any existing property binding on this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusButtonDown</td><td>
Occurs when the stylus button is pressed while the pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusButtonUp</td><td>
Occurs when the stylus button is released while the pointer is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusDown</td><td>
Occurs when the stylus touches the digitizer while the stylus is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusEnter</td><td>
Occurs when the stylus enters the bounds of this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusInAirMove</td><td>
Occurs when the stylus moves over an element without actually touching the digitizer.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusInRange</td><td>
Occurs when the stylus is close enough to the digitizer to be detected, while over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusLeave</td><td>
Occurs when the stylus leaves the bounds of the element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusMove</td><td>
Occurs when the stylus moves over this element. The stylus must move while on the digitizer to raise this event. Otherwise, StylusInAirMove is raised instead.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusOutOfRange</td><td>
Occurs when the stylus is too far from the digitizer to be detected, while over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusSystemGesture</td><td>
Occurs when a user performs one of several stylus gestures.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>StylusUp</td><td>
Occurs when the user raises the stylus off the digitizer while it is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="069b9caa-18ca-8060-f44e-73df7dabe9cd">TagClick</a></td><td>
Track changes to tag (de)selection.</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>TargetUpdated</td><td>
Occurs when the target value changes for any property binding on this element.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>TextInput</td><td>
Occurs when this element gets text in a device-independent manner.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ToolTipClosing</td><td>
Occurs just before any tooltip on the element is closed.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>ToolTipOpening</td><td>
Occurs when any tooltip on the element is opened.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>TouchDown</td><td>
Occurs when a finger touches the screen while the finger is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>TouchEnter</td><td>
Occurs when a touch moves from outside to inside the bounds of this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>TouchLeave</td><td>
Occurs when a touch moves from inside to outside the bounds of this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>TouchMove</td><td>
Occurs when a finger moves on the screen while the finger is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>TouchUp</td><td>
Occurs when a finger is raised off of the screen while the finger is over this element.
 (Inherited from UIElement.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td>Unloaded</td><td>
Occurs when the element is removed from within an element tree of loaded elements.
 (Inherited from FrameworkElement.)</td></tr></table>&nbsp;
<a href="#tag-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="e7328aed-b2a9-39f9-44a4-7b2907dd36d9">tagBtn</a></td><td /></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="0dbc87ba-0718-fb07-c35e-3a2944942edf">TagClickEvent</a></td><td>
Definition of the click routed event.</td></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="fd53b7da-1f11-42a0-5a61-d9d0429956b2">tagIndicator</a></td><td /></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="49d6097e-a141-706d-c22a-1f6319078970">tagName</a></td><td /></tr></table>&nbsp;
<a href="#tag-class">Back to Top</a>

## Explicit Interface Implementations
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td><a href="c8c1b662-0443-3803-23b5-7192f368cc3e">IComponentConnector.Connect</a></td><td /></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>IAddChild.AddChild</td><td>
This type or member supports the Windows Presentation Foundation (WPF) infrastructure and is not intended to be used directly from your code.
 (Inherited from ContentControl.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>System#Windows#Media#Composition#DUCE#IResource#AddRefOnChannel</td><td> (Inherited from Visual.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>IAddChild.AddText</td><td>
This type or member supports the Windows Presentation Foundation (WPF) infrastructure and is not intended to be used directly from your code.
 (Inherited from ContentControl.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>System#Windows#Media#Composition#DUCE#IResource#Get3DHandle</td><td> (Inherited from Visual.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>System#Windows#Media#Composition#DUCE#IResource#GetChannel</td><td> (Inherited from Visual.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>System#Windows#Media#Composition#DUCE#IResource#GetChannelCount</td><td> (Inherited from Visual.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>System#Windows#Media#Composition#DUCE#IResource#GetHandle</td><td> (Inherited from Visual.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>IQueryAmbient.IsAmbientPropertyAvailable</td><td>
For a description of this member, see the IsAmbientPropertyAvailable(String) method.
 (Inherited from FrameworkElement.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>System#Windows#Media#Composition#DUCE#IResource#ReleaseOnChannel</td><td> (Inherited from Visual.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private method](media/privmethod.gif "Private method")</td><td>System#Windows#Media#Composition#DUCE#IResource#RemoveChildFromParent</td><td> (Inherited from Visual.)</td></tr><tr><td>![Explicit interface implementation](media/pubinterface.gif "Explicit interface implementation")![Private property](media/privproperty.gif "Private property")</td><td>System#Windows#Markup#IHaveResources#Resources</td><td> (Inherited from FrameworkElement.)</td></tr></table>&nbsp;
<a href="#tag-class">Back to Top</a>

## See Also


#### Reference
<a href="043a9407-ac38-b3ac-7348-a6090af495ad">WetHatLab.OneNote.TaggingKit.common.ui Namespace</a><br />