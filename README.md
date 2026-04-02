# WPF Tile View Demo
This sample shows how to build a tile-based workspace in a WPF application using the Syncfusion Tile View control. It demonstrates minimized and maximized tiles, smooth drag-and-drop reordering, different templates for minimized and maximized tiles, and options to control how much space minimized tiles occupy. Users can click to maximize a tile, move tiles around, and customize the look and behavior of the minimize/maximize buttons.

## Features
- Three item states: Maximized, Minimized, and Normal
- Drag-and-drop tile reordering with smooth animations
- Minimized items orientation: Left, Top, Right, or Bottom
- Control the minimized area size via percentage
- Separate templates for minimized and maximized tiles
- Virtualization support for large item collections
- Interactive close and maximize buttons with customizable styles
- Theme support and styling to match application branding

## Getting Started
1. Create a new WPF project in Visual Studio (e.g., WpfTileViewDemo).
2. Install the NuGet package: Syncfusion.Tools.WPF.
3. Add the Syncfusion XML namespace in XAML:
   - xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
4. Place a TileViewControl in your Window/Page and add TileViewItem elements.
5. Configure behavior and layout:
   - Set MinimizedItemsOrientation to Left/Top/Right/Bottom
   - Set MinimizedItemsPercentage to control minimized area size
   - Set initial TileViewItem.State to Maximized/Minimized/Normal
   - Provide Minimized and Maximized templates or content
6. Apply a theme with syncfusion:SkinStorage.VisualStyle as needed.

## Usage Tips
- Choose an initial maximized item to focus user attention.
- Enable drag reordering to let users arrange tiles intuitively.
- Use ItemTemplate/ItemContainerStyle to define Normal/Minimized/Maximized visuals.
- Style the minimize and maximize buttons for brand consistency.
- Handle state-change events to update related UI when a tile is maximized.

## About the Sample
This sample is a concise starting point for building a Windows-style tile interface. It highlights common capabilities such as orientation of minimized items, control of minimized area percentage, item state management, and customizable button styles. Extend it with your own data templates, commands, and themes to deliver a polished, responsive tile layout that users can quickly understand and control.
