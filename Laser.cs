using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp
{
    public class Laser : Actor
    {
        public Laser(int x, int y)
        {
            SetVelocity(new Point(0, 0));
            SetPosition(new Point(x, y));
            SetImage(Constants.IMAGE_LASER);
            SetHeight(0);
            SetWidth(0);
            GetImage();
        }
    }
}
