public static class MyData
{
    public static SubTitle[] getSubTitles()
    {
        SubTitle[] subTitles = {
            new SubTitle("Nhà xa nên mình phải ở trọ cuộc sống ở trọ thiếu thốn đủ thứ, sau bao nhiêu cố gắng thì ngày này cũng tới.."),
            new SubTitle("Mình sắp ra trường, được nghỉ một thời gian nên mình sẽ về nhà.."),
            new SubTitle("Có lẽ, Mình sẽ đi cùng Thang Van cho yên tâm.. "),
        };

        return subTitles;
    }
}
public class SubTitle
{
    public string subTitle { get; }

    public SubTitle(string subTitle)
    {
        this.subTitle = subTitle;
    }
}