
namespace ScreenShot
{
    /// <summary>
    /// 图片移动的极限值
    /// </summary>
    public class Limit
    {
        public double Left { get; set; } = ScreenUi.ScreenWidth;
        public double Right { get; set; } = 0;
        public double Top { get; set; } = ScreenUi.ScreenHeight;
        public double Bottom { get; set; } = 0;

        public Limit Clone()
        {
            return MemberwiseClone() as Limit;
        }

        public Limit()
        {

        }
    }

    /// <summary>
    /// 注册名称以及对应图片极限值
    /// </summary>
    public class NameAndLimit
    {
        public string Name { get; set; }
        public Limit Limit { get; set; }

        public NameAndLimit(string name)
        {
            Name = name;
            Limit = ScreenUi.Current.MainImage.Limit.Clone();
        }
    }
}
