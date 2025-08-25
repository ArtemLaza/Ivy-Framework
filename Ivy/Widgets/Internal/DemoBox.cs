using Ivy.Core;
using Ivy.Shared;

// ReSharper disable once CheckNamespace
namespace Ivy;

/// <summary>
/// Represents a demo box widget that provides a simplified container for demonstration and testing purposes.
/// This widget offers basic styling capabilities including borders, padding, margins, and content alignment,
/// making it ideal for creating example layouts, testing design patterns, and building demonstration interfaces.
/// 
/// DemoBox is designed as a lightweight alternative to the full Box widget, providing essential styling
/// properties while maintaining simplicity for demonstration scenarios. This widget is not intended for production use.
/// </summary>
public record DemoBox : WidgetBase<DemoBox>
{
    /// <summary>
    /// Initializes a new instance of the DemoBox class with the specified content.
    /// </summary>
    /// <param name="content">Variable number of content elements to display within the demo box.</param>
    public DemoBox(params IEnumerable<object> content) : base(content.ToArray())
    {
    }

    /// <summary>
    /// Gets or sets the thickness of the border around the demo box.
    /// This controls the width of the border lines on all sides of the container.
    /// Default is 1 unit (thin border).
    /// </summary>
    [Prop] public Thickness BorderThickness { get; set; } = new(1);

    /// <summary>
    /// Gets or sets the border radius for the demo box corners.
    /// This determines how rounded the corners of the box appear, from sharp edges to fully rounded.
    /// Default is <see cref="BorderRadius.Rounded"/>.
    /// </summary>
    [Prop] public BorderRadius BorderRadius { get; set; } = BorderRadius.Rounded;

    /// <summary>
    /// Gets or sets the style of the border around the demo box.
    /// This controls the visual appearance of the border lines (solid, dashed, dotted, etc.).
    /// Default is <see cref="BorderStyle.Solid"/>.
    /// </summary>
    [Prop] public BorderStyle BorderStyle { get; set; } = BorderStyle.Solid;

    /// <summary>
    /// Gets or sets the internal spacing within the demo box.
    /// This controls the space between the border and the content inside the box.
    /// Default is 4 units (moderate internal spacing).
    /// </summary>
    [Prop] public Thickness Padding { get; set; } = new(4);

    /// <summary>
    /// Gets or sets the external spacing around the demo box.
    /// This controls the space between the box and other elements outside of it.
    /// Default is 0 units (no external spacing).
    /// </summary>
    [Prop] public Thickness Margin { get; set; } = new(0);

    /// <summary>
    /// Gets or sets the alignment of content within the demo box.
    /// This controls how content is positioned relative to the box boundaries.
    /// Default is <see cref="Align.TopLeft"/>.
    /// </summary>
    [Prop] public Align? ContentAlign { get; set; } = Align.TopLeft;
}

/// <summary>
/// Extension methods for the DemoBox class that provide a fluent API for easy configuration.
/// Each method returns a new DemoBox instance with the updated configuration, following the immutable pattern.
/// </summary>
public static class DemoBoxExtensions
{
    /// <summary>
    /// Sets the border thickness using a single integer value for uniform thickness on all sides.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="thickness">The uniform border thickness in units.</param>
    /// <returns>A new DemoBox instance with the updated border thickness.</returns>
    public static DemoBox BorderThickness(this DemoBox demoBox, int thickness) => demoBox with { BorderThickness = new(thickness) };

    /// <summary>
    /// Sets the border thickness using a Thickness object for precise control over individual sides.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="thickness">The Thickness object defining border thickness for each side.</param>
    /// <returns>A new DemoBox instance with the updated border thickness.</returns>
    public static DemoBox BorderThickness(this DemoBox demoBox, Thickness thickness) => demoBox with { BorderThickness = thickness };

    /// <summary>
    /// Sets the border radius for the demo box corners.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="radius">The border radius style to apply.</param>
    /// <returns>A new DemoBox instance with the updated border radius.</returns>
    public static DemoBox BorderRadius(this DemoBox demoBox, BorderRadius radius) => demoBox with { BorderRadius = radius };

    /// <summary>
    /// Sets the border style for the demo box.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="style">The border style to apply.</param>
    /// <returns>A new DemoBox instance with the updated border style.</returns>
    public static DemoBox BorderStyle(this DemoBox demoBox, BorderStyle style) => demoBox with { BorderStyle = style };

    /// <summary>
    /// Sets the padding using a single integer value for uniform padding on all sides.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="padding">The uniform padding in units.</param>
    /// <returns>A new DemoBox instance with the updated padding.</returns>
    public static DemoBox Padding(this DemoBox demoBox, int padding) => demoBox with { Padding = new(padding) };

    /// <summary>
    /// Sets the padding using a Thickness object for precise control over individual sides.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="padding">The Thickness object defining padding for each side.</param>
    /// <returns>A new DemoBox instance with the updated padding.</returns>
    public static DemoBox Padding(this DemoBox demoBox, Thickness padding) => demoBox with { Padding = padding };

    /// <summary>
    /// Sets the margin using a single integer value for uniform margin on all sides.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="margin">The uniform margin in units.</param>
    /// <returns>A new DemoBox instance with the updated margin.</returns>
    public static DemoBox Margin(this DemoBox demoBox, int margin) => demoBox with { Margin = new(margin) };

    /// <summary>
    /// Sets the margin using a Thickness object for precise control over individual sides.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="margin">The Thickness object defining margin for each side.</param>
    /// <returns>A new DemoBox instance with the updated margin.</returns>
    public static DemoBox Margin(this DemoBox demoBox, Thickness margin) => demoBox with { Margin = margin };

    /// <summary>
    /// Sets the content to be displayed within the demo box.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="content">Variable number of content elements to display.</param>
    /// <returns>A new DemoBox instance with the updated content.</returns>
    public static DemoBox Content(this DemoBox demoBox, params object[] content) => demoBox with { Children = content };

    /// <summary>
    /// Sets the alignment of content within the demo box.
    /// </summary>
    /// <param name="demoBox">The DemoBox to configure.</param>
    /// <param name="align">The alignment to apply to the content.</param>
    /// <returns>A new DemoBox instance with the updated content alignment.</returns>
    public static DemoBox ContentAlign(this DemoBox demoBox, Align? align) => demoBox with { ContentAlign = align };
}
