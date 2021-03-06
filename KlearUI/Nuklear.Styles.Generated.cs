namespace KlearUI
{

        public unsafe partial class nk_style_text
        {
            public NkColor color = new NkColor();
            public NkVec2 padding = new NkVec2();
        }

        public unsafe partial class nk_style_button
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkColor text_background = new NkColor();
            public NkColor text_normal = new NkColor();
            public NkColor text_hover = new NkColor();
            public NkColor text_active = new NkColor();
            public Align text_alignment;
            public float border;
            public float rounding;
            public NkVec2 padding = new NkVec2();
            public NkVec2 image_padding = new NkVec2();
            public NkVec2 touch_padding = new NkVec2();
            public NkHandle userdata = new NkHandle();
            public NkDrawNotify draw_begin;
            public NkDrawNotify draw_end;
        }

        public unsafe partial class nk_style_toggle
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkStyleItem cursor_normal = new NkStyleItem();
            public NkStyleItem cursor_hover = new NkStyleItem();
            public NkColor text_normal = new NkColor();
            public NkColor text_hover = new NkColor();
            public NkColor text_active = new NkColor();
            public NkColor text_background = new NkColor();
            public uint text_alignment;
            public NkVec2 padding = new NkVec2();
            public NkVec2 touch_padding = new NkVec2();
            public float spacing;
            public float border;
            public NkHandle userdata = new NkHandle();
            public NkDrawNotify draw_begin;
            public NkDrawNotify draw_end;
        }

        public unsafe partial class nk_style_selectable
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem pressed = new NkStyleItem();
            public NkStyleItem normal_active = new NkStyleItem();
            public NkStyleItem hover_active = new NkStyleItem();
            public NkStyleItem pressed_active = new NkStyleItem();
            public NkColor text_normal = new NkColor();
            public NkColor text_hover = new NkColor();
            public NkColor text_pressed = new NkColor();
            public NkColor text_normal_active = new NkColor();
            public NkColor text_hover_active = new NkColor();
            public NkColor text_pressed_active = new NkColor();
            public NkColor text_background = new NkColor();
            public uint text_alignment;
            public float rounding;
            public NkVec2 padding = new NkVec2();
            public NkVec2 touch_padding = new NkVec2();
            public NkVec2 image_padding = new NkVec2();
            public NkHandle userdata = new NkHandle();
            public NkDrawNotify draw_begin;
            public NkDrawNotify draw_end;
        }

        public unsafe partial class nk_style_slider
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkColor bar_normal = new NkColor();
            public NkColor bar_hover = new NkColor();
            public NkColor bar_active = new NkColor();
            public NkColor bar_filled = new NkColor();
            public NkStyleItem cursor_normal = new NkStyleItem();
            public NkStyleItem cursor_hover = new NkStyleItem();
            public NkStyleItem cursor_active = new NkStyleItem();
            public float border;
            public float rounding;
            public float bar_height;
            public NkVec2 padding = new NkVec2();
            public NkVec2 spacing = new NkVec2();
            public NkVec2 cursor_size = new NkVec2();
            public bool show_buttons;
            public nk_style_button inc_button = new nk_style_button();
            public nk_style_button dec_button = new nk_style_button();
            public Symbols inc_symbol;
            public Symbols dec_symbol;
            public NkHandle userdata = new NkHandle();
            public NkDrawNotify draw_begin;
            public NkDrawNotify draw_end;
        }

        public unsafe partial class nk_style_progress
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkStyleItem cursor_normal = new NkStyleItem();
            public NkStyleItem cursor_hover = new NkStyleItem();
            public NkStyleItem cursor_active = new NkStyleItem();
            public NkColor cursor_border_color = new NkColor();
            public float rounding;
            public float border;
            public float cursor_border;
            public float cursor_rounding;
            public NkVec2 padding = new NkVec2();
            public NkHandle userdata = new NkHandle();
            public NkDrawNotify draw_begin;
            public NkDrawNotify draw_end;
        }

        public unsafe partial class nk_style_scrollbar
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkStyleItem cursor_normal = new NkStyleItem();
            public NkStyleItem cursor_hover = new NkStyleItem();
            public NkStyleItem cursor_active = new NkStyleItem();
            public NkColor cursor_border_color = new NkColor();
            public float border;
            public float rounding;
            public float border_cursor;
            public float rounding_cursor;
            public NkVec2 padding = new NkVec2();
            public bool show_buttons;
            public nk_style_button inc_button = new nk_style_button();
            public nk_style_button dec_button = new nk_style_button();
            public Symbols inc_symbol;
            public Symbols dec_symbol;
            public NkHandle userdata = new NkHandle();
            public NkDrawNotify draw_begin;
            public NkDrawNotify draw_end;
        }

        public unsafe partial class nk_style_edit
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public nk_style_scrollbar scrollbar = new nk_style_scrollbar();
            public NkColor cursor_normal = new NkColor();
            public NkColor cursor_hover = new NkColor();
            public NkColor cursor_text_normal = new NkColor();
            public NkColor cursor_text_hover = new NkColor();
            public NkColor text_normal = new NkColor();
            public NkColor text_hover = new NkColor();
            public NkColor text_active = new NkColor();
            public NkColor selected_normal = new NkColor();
            public NkColor selected_hover = new NkColor();
            public NkColor selected_text_normal = new NkColor();
            public NkColor selected_text_hover = new NkColor();
            public float border;
            public float rounding;
            public float cursor_size;
            public NkVec2 scrollbar_size = new NkVec2();
            public NkVec2 padding = new NkVec2();
            public float row_padding;
        }

        public unsafe partial class nk_style_property
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkColor label_normal = new NkColor();
            public NkColor label_hover = new NkColor();
            public NkColor label_active = new NkColor();
            public Symbols sym_left;
            public Symbols sym_right;
            public float border;
            public float rounding;
            public NkVec2 padding = new NkVec2();
            public nk_style_edit edit = new nk_style_edit();
            public nk_style_button inc_button = new nk_style_button();
            public nk_style_button dec_button = new nk_style_button();
            public NkHandle userdata = new NkHandle();
            public NkDrawNotify draw_begin;
            public NkDrawNotify draw_end;
        }

        public unsafe partial class nk_style_chart
        {
            public NkStyleItem background = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkColor selected_color = new NkColor();
            public NkColor color = new NkColor();
            public float border;
            public float rounding;
            public NkVec2 padding = new NkVec2();
        }

        public unsafe partial class nk_style_combo
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkColor label_normal = new NkColor();
            public NkColor label_hover = new NkColor();
            public NkColor label_active = new NkColor();
            public NkColor symbol_normal = new NkColor();
            public NkColor symbol_hover = new NkColor();
            public NkColor symbol_active = new NkColor();
            public nk_style_button button = new nk_style_button();
            public Symbols sym_normal;
            public Symbols sym_hover;
            public Symbols sym_active;
            public float border;
            public float rounding;
            public NkVec2 content_padding = new NkVec2();
            public NkVec2 button_padding = new NkVec2();
            public NkVec2 spacing = new NkVec2();
        }

        public unsafe partial class nk_style_tab
        {
            public NkStyleItem background = new NkStyleItem();
            public NkColor border_color = new NkColor();
            public NkColor text = new NkColor();
            public nk_style_button tab_maximize_button = new nk_style_button();
            public nk_style_button tab_minimize_button = new nk_style_button();
            public nk_style_button node_maximize_button = new nk_style_button();
            public nk_style_button node_minimize_button = new nk_style_button();
            public Symbols sym_minimize;
            public Symbols sym_maximize;
            public float border;
            public float rounding;
            public float indent;
            public NkVec2 padding = new NkVec2();
            public NkVec2 spacing = new NkVec2();
        }

        public unsafe partial class nk_style_window_header
        {
            public NkStyleItem normal = new NkStyleItem();
            public NkStyleItem hover = new NkStyleItem();
            public NkStyleItem active = new NkStyleItem();
            public nk_style_button close_button = new nk_style_button();
            public nk_style_button minimize_button = new nk_style_button();
            public Symbols close_symbol;
            public Symbols minimize_symbol;
            public Symbols maximize_symbol;
            public NkColor label_normal = new NkColor();
            public NkColor label_hover = new NkColor();
            public NkColor label_active = new NkColor();
            public StyleHeaderAlign align;
            public NkVec2 padding = new NkVec2();
            public NkVec2 label_padding = new NkVec2();
            public NkVec2 spacing = new NkVec2();
        }

        public unsafe partial class nk_style_window
        {
            public nk_style_window_header header = new nk_style_window_header();
            public NkStyleItem fixed_background = new NkStyleItem();
            public NkColor background = new NkColor();
            public NkColor border_color = new NkColor();
            public NkColor popup_border_color = new NkColor();
            public NkColor combo_border_color = new NkColor();
            public NkColor contextual_border_color = new NkColor();
            public NkColor menu_border_color = new NkColor();
            public NkColor group_border_color = new NkColor();
            public NkColor tooltip_border_color = new NkColor();
            public NkStyleItem scaler = new NkStyleItem();
            public float border;
            public float combo_border;
            public float contextual_border;
            public float menu_border;
            public float group_border;
            public float tooltip_border;
            public float popup_border;
            public float min_row_height_padding;
            public float rounding;
            public NkVec2 spacing = new NkVec2();
            public NkVec2 scrollbar_size = new NkVec2();
            public NkVec2 min_size = new NkVec2();
            public NkVec2 padding = new NkVec2();
            public NkVec2 group_padding = new NkVec2();
            public NkVec2 popup_padding = new NkVec2();
            public NkVec2 combo_padding = new NkVec2();
            public NkVec2 contextual_padding = new NkVec2();
            public NkVec2 menu_padding = new NkVec2();
            public NkVec2 tooltip_padding = new NkVec2();
        }
    public unsafe static partial class Nk
    {
        public static NkVec2 nk_panel_get_padding(NkStyle style, PanelKind type)
        {
            switch (type)
            {
                default:
                case PanelKind.Window:
                    return (NkVec2)(style.Window.padding);
                case PanelKind.Group:
                    return (NkVec2)(style.Window.group_padding);
                case PanelKind.Popup:
                    return (NkVec2)(style.Window.popup_padding);
                case PanelKind.Contextual:
                    return (NkVec2)(style.Window.contextual_padding);
                case PanelKind.Combo:
                    return (NkVec2)(style.Window.combo_padding);
                case PanelKind.Menu:
                    return (NkVec2)(style.Window.menu_padding);
                case PanelKind.Tooltip:
                    return (NkVec2)(style.Window.menu_padding);
            }

        }

        public static float nk_panel_get_border(NkStyle style, PanelFlags flags, PanelKind type)
        {
            if ((flags & PanelFlags.Border) != 0)
            {
                switch (type)
                {
                    default:
                    case PanelKind.Window:
                        return (float)(style.Window.border);
                    case PanelKind.Group:
                        return (float)(style.Window.group_border);
                    case PanelKind.Popup:
                        return (float)(style.Window.popup_border);
                    case PanelKind.Contextual:
                        return (float)(style.Window.contextual_border);
                    case PanelKind.Combo:
                        return (float)(style.Window.combo_border);
                    case PanelKind.Menu:
                        return (float)(style.Window.menu_border);
                    case PanelKind.Tooltip:
                        return (float)(style.Window.menu_border);
                }
            }
            else return (float)(0);
        }

        public static NkColor nk_panel_get_border_color(NkStyle style, PanelKind type)
        {
            switch (type)
            {
                default:
                case PanelKind.Window:
                    return (NkColor)(style.Window.border_color);
                case PanelKind.Group:
                    return (NkColor)(style.Window.group_border_color);
                case PanelKind.Popup:
                    return (NkColor)(style.Window.popup_border_color);
                case PanelKind.Contextual:
                    return (NkColor)(style.Window.contextual_border_color);
                case PanelKind.Combo:
                    return (NkColor)(style.Window.combo_border_color);
                case PanelKind.Menu:
                    return (NkColor)(style.Window.menu_border_color);
                case PanelKind.Tooltip:
                    return (NkColor)(style.Window.menu_border_color);
            }

        }

        public static float nk_layout_row_calculate_usable_space(NkStyle style, PanelKind type, float total_space, int columns)
        {
            float panel_padding;
            float panel_spacing;
            float panel_space;
            NkVec2 spacing = new NkVec2();
            NkVec2 padding = new NkVec2();
            spacing = (NkVec2)(style.Window.spacing);
            padding = (NkVec2)(nk_panel_get_padding(style, (type)));
            panel_padding = (float)(2 * padding.x);
            panel_spacing = (float)((float)((columns - 1) < (0) ? (0) : (columns - 1)) * spacing.x);
            panel_space = (float)(total_space - panel_padding - panel_spacing);
            return (float)(panel_space);
        }
    }
}