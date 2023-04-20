using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace MKH.Library.Clasess
{
    public class DigitToStr
    {
        /// <summary>
        /// عدد رادریافت وبه حروف تبدیل می کند 
        /// </summary>
        /// <param name="Ragham">رقم </param>
        /// <returns>به حروف عدد را برمی گرداند</returns>
        public static string ConvertRaghamToHorof(Int64 Ragham)
        {
            return ConvertRaghamToHorof(ConvertRaghamToJodaJoda(Ragham));
        }
        /// <summary>
        /// یک عدد به صورت سه رقم جدا را دریافت وبه حروف تبدیل می کند
        /// </summary>
        /// <param name="Ragham"></param>
        /// <returns></returns>
        public static string ConvertRaghamToHorof(string Ragham)
        {
            string horof = "";

            try
            {
                string[] AddJoda = Ragham.Split(',');
                for (int i = 0; i < AddJoda.Length; i++)
                {
                    //MessageBox.Show(AddJoda[i]);
                    string strh = pishConvertRaghamToHorof3(int.Parse(AddJoda[i]), AddJoda.Length - i);
                    if (horof == "")
                    {
                        horof = horof + strh;
                    }
                    else
                    {
                        if (strh != "") horof = horof + " و " + strh;
                    }

                }
                return horof;
            }
            catch (Exception e1)
            {
                return "error";
            }
            finally
            {
            }

        }
        /// <summary>
        /// اعداد از صفر تا 19 را به حروف تبدیل میکند
        /// </summary>
        /// <param name="Ragham">عدد بین 0 تا 19</param>
        /// <returns>حروف را برمی گرداند در صورت خطا -1  و درصورت عدد نامعتبر تهی برمی گرداند</returns>
        private static string ConvertRaghamToHorof0to19(int Ragham)
        {
            try
            {
                //اعداد صفر  تا بیست
                if (Ragham > 19) return "";
                switch (Ragham)
                {
                    case 0:
                        return "صفر";
                        break;

                    case 1:
                        return "یک ";
                        break;
                    case 2:
                        return "دو";
                        break;
                    case 3:
                        return "سه ";
                        break;
                    case 4:
                        return "چهار";
                        break;
                    case 5:
                        return "پنج ";
                        break;
                    case 6:
                        return "شش ";
                        break;
                    case 7:
                        return "هفت ";
                        break;
                    case 8:
                        return "هشت ";
                        break;
                    case 9:
                        return "نه ";
                        break;
                    case 10:
                        return "ده ";
                    case 11:
                        return "یازده ";
                    case 12:
                        return "دوازده ";
                    case 13:
                        return "سیزده ";
                    case 14:
                        return "چهارده ";
                    case 15:
                        return "پانزده ";
                    case 16:
                        return "شانزده ";
                    case 17:
                        return "هیفده ";
                    case 18:
                        return "هیجده ";
                    case 19:
                        return "نوزده ";
                    //case 20:
                    //    return "بیست"; 

                }


                return "";
            }
            catch (Exception e)
            {
                return "-1";
            }
            finally
            {
            }

        }
        /// <summary>
        /// اعداد از بیست   تا نود نه را به حروف تبدیل میکند
        /// </summary>
        /// <param name="Ragham">عدد بین 20 تا 99</param>
        /// <returns>حروف را برمی گرداند در صورت خطا -1  و درصورت عدد نامعتبر تهی برمی گرداند</returns>
        private static string ConvertRaghamToHorof20to99(int Ragham)
        {
            try
            {
                //اعداد صفر  تا بیست
                if (!(Ragham > 19 && Ragham < 100)) return "";
                // برای تبدیل به حروف  رقم دوم
                string str = ConvertRaghamToHorof0to19(int.Parse(Ragham.ToString().Substring(1)));
                if (Ragham > 19 && Ragham < 30)
                {
                    if (Ragham == 20)
                    {
                        return "بیست";
                    }
                    else
                    {
                        return "بیست و" + str;
                    }

                }
                else if (Ragham > 29 && Ragham < 40)
                {
                    if (Ragham == 30)
                    {
                        return "سی";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "سی و" + str;
                    }
                }
                else if (Ragham > 39 && Ragham < 50)
                {
                    if (Ragham == 40)
                    {
                        return "چهل";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "چهل و" + str;
                    }
                }
                else if (Ragham > 49 && Ragham < 60)
                {
                    if (Ragham == 50)
                    {
                        return "پنجاه";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "پنجاه و" + str;
                    }
                }
                else if (Ragham > 59 && Ragham < 70)
                {
                    if (Ragham == 60)
                    {
                        return "شصت";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "شصت و" + str;
                    }
                }
                else if (Ragham > 69 && Ragham < 80)
                {
                    if (Ragham == 70)
                    {
                        return "هفتاد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "هفتادو" + str;
                    }
                }
                else if (Ragham > 79 && Ragham < 90)
                {
                    if (Ragham == 80)
                    {
                        return "هشتاد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "هشتادو" + str;
                    }
                }
                else if (Ragham > 89 && Ragham < 100)
                {
                    if (Ragham == 90)
                    {
                        return "نود";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "نودو" + str;
                    }
                }
                return "";
            }
            catch (Exception e)
            {
                return "-1";
            }
            finally
            {
            }

        }
        /// <summary>
        /// اعداد از 0   تا نود نه را به حروف تبدیل میکند
        /// </summary>
        /// <param name="Ragham">عدد بین 0 تا 99</param>
        /// <returns>حروف را برمی گرداند در صورت خطا -1  و درصورت عدد نامعتبر تهی برمی گرداند</returns>
        private static string ConvertRaghamToHorof0to99(int Ragham)
        {
            try
            {
                if (Ragham > 99) return "";
                if (Ragham < 20)
                {
                    return ConvertRaghamToHorof0to19(Ragham);
                }
                else if (Ragham < 100)
                {
                    return ConvertRaghamToHorof20to99(Ragham);
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
            finally
            { }
        }
        /// <summary>
        /// اعداد از صد  تانهصدو نودو نه را به حروف تبدیل میکند
        /// </summary>
        /// <param name="Ragham">عدد بین 100 تا 999</param>
        /// <returns>حروف را برمی گرداند در صورت خطا -1  و درصورت عدد نامعتبر تهی برمی گرداند</returns>
        private static string ConvertRaghamToHorof100to999(int Ragham)
        {
            try
            {
                //اعداد 100  تا 999
                if (!(Ragham > 99 && Ragham < 1000)) return "";
                // برای تبدیل به حروف  رقم دوم

                string str = ConvertRaghamToHorof0to99(int.Parse(Ragham.ToString().Substring(1)));
                if (Ragham > 99 && Ragham < 200)
                {
                    if (Ragham == 100)
                    {
                        return "صد";
                    }
                    else
                    {
                        return "صدو" + str;
                    }

                }
                else if (Ragham > 199 && Ragham < 300)
                {
                    if (Ragham == 200)
                    {
                        return "دویست";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "دویست و" + str;
                    }
                }
                else if (Ragham > 299 && Ragham < 400)
                {
                    if (Ragham == 300)
                    {
                        return "سیصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "سیصدو" + str;
                    }
                }
                else if (Ragham > 399 && Ragham < 500)
                {
                    if (Ragham == 400)
                    {
                        return "چهارصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "چهارصدو" + str;
                    }
                }
                else if (Ragham > 499 && Ragham < 600)
                {
                    if (Ragham == 500)
                    {
                        return "پانصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "پانصدو" + str;
                    }
                }
                else if (Ragham > 599 && Ragham < 700)
                {
                    if (Ragham == 600)
                    {
                        return "ششصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "ششصدو" + str;
                    }
                }
                else if (Ragham > 699 && Ragham < 800)
                {
                    if (Ragham == 700)
                    {
                        return "هفتصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "هفتصدو" + str;
                    }
                }
                else if (Ragham > 799 && Ragham < 900)
                {
                    if (Ragham == 800)
                    {
                        return "هشتصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "هشتصدو" + str;
                    }
                }
                else if (Ragham > 899 && Ragham < 1000)
                {
                    if (Ragham == 900)
                    {
                        return "نهصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "نهصدو" + str;
                    }
                }
                return "";
            }
            catch (Exception e)
            {
                return "-1";
            }
            finally
            {
            }

        }
        /// <summary>
        /// اعداد از صفر تا 999 را به حروف تبدیل می کند
        /// </summary>
        /// <param name="Ragham"></param>
        /// <returns></returns>
        private static string ConvertRaghamToHorof0to999(int Ragham)
        {
            try
            {

                if (!(Ragham < 1000)) return "";

                if (Ragham < 20)
                {
                    return ConvertRaghamToHorof0to19(Ragham);
                }
                else if (Ragham > 19 && Ragham < 100)
                {
                    return ConvertRaghamToHorof20to99(Ragham);
                }
                else if (Ragham > 99 && Ragham < 1000)
                {
                    return ConvertRaghamToHorof100to999(Ragham);
                }
                else
                {
                    return "خطا برنامه نویسی";
                }

                return "";
            }
            catch (Exception e)
            {
                return "-1";
            }
            finally
            {
            }

        }
        /// <summary>
        /// یک عدد سه رقمی و موقعیت انرا دریافت و به حروف تبدیل می کند
        /// </summary>
        /// <param name="Ragham">عدد سه رقمی</param>
        /// <param name="LocationRagham"> موقیت عدد 2 =هزار 3== میلیون 4= میلیارد</param>
        /// <returns></returns>
        private static string pishConvertRaghamToHorof3(int Ragham, int LocationRagham)
        {
            try
            {   //اگر عدد صفر نیازبه پیش ندارد
                if (Ragham == 0) return "";
                if (Ragham > 1000) return "";

                //string str = ConvertRaghamToHorof0to999(Ragham);
                if (Ragham == 0) return "";
                switch (LocationRagham)
                {
                    case 1:
                        return ConvertRaghamToHorof0to999(Ragham);
                    case 2:
                        return ConvertRaghamToHorof0to999(Ragham) + " هزار";
                    case 3:
                        return ConvertRaghamToHorof0to999(Ragham) + " میلیون ";
                    case 4:
                        return ConvertRaghamToHorof0to999(Ragham) + " میلیارد";
                    case 5:
                        return ConvertRaghamToHorof0to999(Ragham) + "تریلیارد";
                    case 6:

                        return ConvertRaghamToHorof0to999(Ragham) + " ??? ";
                    case 7:

                        return ConvertRaghamToHorof0to999(Ragham) + " ??? ";
                    case 8:

                        return ConvertRaghamToHorof0to999(Ragham) + " ??? ";
                    case 9:

                        return ConvertRaghamToHorof0to999(Ragham) + " ??? ";
                }

                return "";
            }
            catch (Exception e)
            {
                return "error";
            }
            finally
            {
            }

        }

        /// <summary>
        /// یک رقم را سه رقم سه رقم جدا می کند
        /// </summary>
        /// <param name="Ragham">رقم که باید حداکثر دوازده رقم باشد</param>
        /// <returns>جداشده سه رقم سه رقم را برمی گرداند</returns>
        public static string ConvertRaghamToJodaJoda(Int64 Ragham)
        {

            try
            {
                string Add = Ragham.ToString();
                Add = Add.Trim(); //فقط دوازده رقم را پشتیبانی می کند
                if (Add.Length > 15) Add = Add.Substring(0, 15);
                if (Add.Trim() == "")
                {

                    return "";
                }

                string j = "";

                if ((Add.Length > 3 && Add.Length < 6) || Add.Length == 6)
                {
                    //MessageBox.Show(i.Substring(3, 1));
                    Add = Add.Substring(0, Add.Length - 3) + "," + Add.Substring(Add.Length - 3, 3);
                }
                else if ((Add.Length > 6 && Add.Length < 9) || Add.Length == 9)
                {

                    Add = Add.Substring(0, Add.Length - 6) +
                           "," + Add.Substring(Add.Length - 6, 3) +
                           "," + Add.Substring(Add.Length - 3, 3);

                }
                else if ((Add.Length > 9 && Add.Length < 12) || Add.Length == 12)
                {
                    //MessageBox.Show(i.Substring(3, 1));
                    Add = Add.Substring(0, Add.Length - 9) +
                          "," + Add.Substring(Add.Length - 9, 3) +
                          "," + Add.Substring(Add.Length - 6, 3) +
                    "," + Add.Substring(Add.Length - 3, 3);
                    //Add = Add.Substring(0, 3) +
                    //       "," + Add.Substring(3, 3) +
                    //       "," + Add.Substring(6, 3) +
                    //       "," + Add.Substring(9, Add.Length - 9);
                }
                else if (Add.Length > 12 && Add.Length < 15)
                {
                    //MessageBox.Show(i.Substring(3, 1));
                    Add = Add.Substring(0, 3) +
                           "," + Add.Substring(3, 3) +
                           "," + Add.Substring(6, 3) +
                            "," + Add.Substring(9, 3) +
                           "," + Add.Substring(12, Add.Length - 12);
                }
                else if (Add.Length < 3)
                {

                }

                return Add;
            }


            catch (Exception e)
            {
                //ClsGlobalClass.ShowMessageErrorFarsi(e, "ConvertRaghamToJodaJoda(Int64 Ragham)");
                return "";

            }
            finally
            {
                //ObjBankPatern.SqlConnection.Close();
                //cmd.Dispose();
                //dap.Dispose();
            }
        }
    }
}
