using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Models
{
    public class LikeEventArgs : EventArgs
    {
        public int ArticleId { get; set; }
    }

    public delegate void LikeAddedEventHandler(object source, LikeEventArgs args);
}
