using System;
using OpenCover.Framework.Model;

public static class Charactor{
    public static string me = "Tôi";
    public static string c1 = "van thang";
    public static string c2 = "Tôi";
    public static string c3 = "Tôi";
}
public static class MySubTitle
{
    public static SubTitle[] getScene1()
    {
        SubTitle[] subTitles = {
            new SubTitle("Nhà xa nên mình phải ở trọ cuộc sống ở trọ thiếu thốn đủ thứ, sau bao nhiêu cố gắng thì ngày này cũng tới..", Charactor.me),
            new SubTitle("Mình sắp ra trường, được nghỉ một thời gian nên mình sẽ về nhà..", Charactor.c1),
            new SubTitle("Có lẽ, Mình sẽ đi cùng Thang Van cho yên tâm.. ", Charactor.me),
        };

        return subTitles;
    }
    public static SubTitle[] getScene2()
    {
        SubTitle[] subTitles = {
            new SubTitle("Tôi luôn cảm thấy sợ mỗi khi đi qua con đường này, tiếng gió thổi cũng làm tôi sởn ra gà", Charactor.me),
            new SubTitle("????", Charactor.c1),
            new SubTitle("Chết tiệt, đi xe kiểu gì vậy chứ", Charactor.me),
            new SubTitle("Đây là đâu..", Charactor.me),
        };

        return subTitles;
    }
}
public class SubTitle
{
    public string fullName { get; }
    public string subTitle { get; }

    public SubTitle(string subTitle, string fullName)
    {
        this.subTitle = subTitle;
        this.fullName = fullName;
    }
}

