using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdftron.PDF.Tools
{
    class TextStrikeoutCreate : TextMarkupCreate
    {
        public TextStrikeoutCreate(PDFViewCtrl ctrl, ToolManager tMan)
            : base(ctrl, tMan)
        {
            mNextToolMode = ToolType.e_text_strikeout;
            mToolMode = ToolType.e_text_strikeout;
        }
    }
}
