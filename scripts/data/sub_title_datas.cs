public static class MySubTitle
{
    public static SubTitle[] getScene1()
    {
        SubTitle[] subTitles = {
            new SubTitle("Nhà xa nên mình phải ở trọ cuộc sống ở trọ thiếu thốn đủ thứ, sau bao nhiêu cố gắng thì ngày này cũng tới.."),
            new SubTitle("Mình sắp ra trường, được nghỉ một thời gian nên mình sẽ về nhà.."),
            new SubTitle("Có lẽ, Mình sẽ đi cùng Thang Van cho yên tâm.. "),
        };

        return subTitles;
    }
    public static SubTitle[] getScene2()
    {
        SubTitle[] subTitles = {
            new SubTitle("Tôi luôn cảm thấy sợ mỗi khi đi qua con đường này, tiếng gió thổi cũng làm tôi sởn ra gà"),
            new SubTitle("????"),
            new SubTitle("Chết tiệt, đi xe kiểu gì vậy chứ"),
            new SubTitle("Đây là đâu.."),
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

