using UnityEngine;

public class Lesson5_IfSwitchLoop : MonoBehaviour
{
    [Header("是否開門")]
    public bool openDoor;
    [Header("分數")]
    public int score = 0;
    [Header("血量")]
    public float HP = 100;
    [Header("道具")]
    public string prop = "紅水";

    public Season season;

    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    public string test;

    private int i = 1;
    private int j = 1;

    [Header ("地板")]
    public GameObject cube;

    public int[] scores = { 100, 99, 88, 77, 66, 55 };

    private void CreatFloor(int length, int width)
    {
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                //API實例化(生成)
                //生成(物件、座標、角度)
                //Vector3三圍向量(保存三個浮點數)
                //Quaternion 角度
                //Quaternion.identity 零角度
                //Quaternion.Euler (x,y,z) 歐拉角度 - 0~360
                Instantiate(cube, new Vector3(j*2, 0, i * 2), Quaternion.Euler(270,0,0));
            }
        }
    }


    private void Awake()
    {
        #region 迴圈
        //使用 for 迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i++)
        {
            print("for 迴圈取得資料：" + scores[1]);
        }

        CreatFloor(30,5);
        //while 迴圈
        //while (布林值) { 當布林值為 true 執行} 
        while (i <= 10)
        {
            print("while 迴圈第" + i + "次");
                i++;
        }

        //迴圈之後評估
        do
        {
            print("do 迴圈第" + j + "次");
            j++;
        } while (j <= 10);

        for (int k = 0; k <=10; k++)
        {
            print("for 迴圈第" + k + "次");
        }

        for (int k = 10; k > 0  ; k--)
        {
            print("for 迴圈第" + k + "次");
        };
        #endregion

        #region 迴圈break - 打斷迴圈並執行迴圈下的程式
        /*
        for (int i = 0; i < 101; i++)
        {
            print("break 迴圈" + i);

            //如果 i = 10 就打斷迴圈並執行迴圈下的程式
            if (i == 10) break;
        }

        print("break 迴圈外的程式");
        */
        #endregion

        #region 迴圈return - 跳出迴圈，且下方的程式皆不執行
        /*
        for (int i = 0; i < 101; i++)
        {
            print("return 迴圈：" + i);

            //如果 i = 10 就跳出方法外，下方的程式皆不執行
            if (i == 10) return;
        }
       
        print("return 迴圈外的程式");
        */
        #endregion

        #region 迴圈continue - 跳過該圈迴圈，爾後迴圈繼續
        /*
        for (int i = 0; i < 20; i++)
        {
            //如果 i = 5 就跳過該迴圈，爾後迴圈繼續
            if (i == 5) continue;
            print("continue 迴圈" + i);
        }
        print("continue 迴圈外的程式");
        */
        #endregion

        #region 迴圈goto - 停止迴圈並跳轉至某標記
        for (int i = 0; i < 10; i++)
        {
            //goto 標記名稱
            if (i == 5) goto Test;
            print("goto 迴圈" + i);
        }
        //標記名稱
    Test:
        //標記陳述式
        print("這是標記陳述式");
        #endregion

    }


    private void Start()
    {
        //if判斷式
        //if(布林值) { 布林值 = true 時執行 }
        if (true)
        {
            print("Hi!,I'm if");
        }
    }

    private void Update()
    {
        complete = count >= 5 ? true : false;

        test = score >= 60 ? "Pass" : score >= 40 ? "補考" : score >= 20 ? "花錢補考" : "Fail";

        switch (prop)
        {
            case "紅水":
                print("Recover HP");
                break;
            case "藍水":
                print("Recover MP");
                break;
            case "黃水":
                print("Plus EXP");
                break;
            //default 可省略
            default:
                print("Can't Use");
                break;
        }

        switch (season)
        {
            case Season.Spring:
                print("spring");
                break;
            case Season.Summer:
                print("summer");
                break;
            case Season.Fall:
                print("fall");
                break;
            case Season.Wunter:
                print("winter");
                break;

        }

        #region if 用法
        //當 openDoor 為 true  執行 開門
        //當 openDoor 為 false 執行 關門
        //if (openDoor == true)
        if (openDoor)
        {
            print("Chi Na Kai Men");
        }
        else
        {
            print("Chi Na Guang Man");
        }

        if (score >= 60)
        {
            print("Pass");
        }
        else if (score >= 40)
        {
            print("補考");
        }
        else if (score >= 20)
        {
            print("付錢補考");
        }
        else
        {
            print("Fail");
        }

        if (HP >= 70)
        {
            print("SAFE~");
        }
        else if (HP >= 20)
        {
            print("WARNNING!");
        }
        else
        {
            print("DANGER!!!!!!!!!!!");
        }
    }
    #endregion
}
