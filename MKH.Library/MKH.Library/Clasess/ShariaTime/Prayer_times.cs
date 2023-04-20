using System;
using System.Collections.Generic;

namespace MKH.Library.Clasess.Shariatime
{
    public class ShariaTimes
    {

        double month, day, longitude, latitude, XX, YY;
        static Double PI = 3.14159265358979;

        public enum City 
        {
            تهران=1,
            کرمانشاه= 2,
            خراسان= 3
        };

        public class CityLocation
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public City Cities { get; set; }

        }

        //public System.Collections.Generic.List<CityLocation> City = 
        //    new {CityLocation.
        //        System.Collections.Generic.List<str>() {str.تهران, str.کرمانشاه};
            
        //struct CityLocation
        //{
        //    int Id;
        //    string Name;
        //    int Latitude;
        //    int Longitude;
        //};
        List<CityLocation> cl = null;
       public ShariaTimes()
        {
            cl = new List<CityLocation> 
            { 
                new CityLocation { Latitude = 35.6961, Longitude = 51.4231, Cities = City.تهران},
                new CityLocation { Latitude = 34.3142, Longitude = 47.0650, Cities = City.کرمانشاه},
                new CityLocation { Latitude = 36.2980, Longitude = 59.6057, Cities = City.خراسان}
            };
        }

        public void SetGeo(double Longitude, double Latitude, double Month, double Day)
        {
            latitude = Latitude;
            longitude = Longitude;
            day = Day;
            month = Month;
        }
        
        public void SetGeo(int SelectLoc, DateTime dateTime)
        {
            latitude = cl[SelectLoc].Latitude;
            longitude = cl[SelectLoc].Longitude;
            day = new Date.DateJalali().GetDayOfMonth(dateTime);
            month = new Date.DateJalali().GetMonth(dateTime);
        }

        private double loc2hor(double z, double d, double p)
        {
            return acosd((cosd(z) - sind(d) * sind(p)) / cosd(d) / cosd(p)) / 15;
        }

        private double rRound(double X, double a)
        {
            double tmp;
            tmp = mod2(X, a);
            if (tmp < 0) tmp = tmp + a;
            return tmp;
        }


        private string hms(double X)
        {
            double h, mp, m, ss;
            string s = "";
            TimeZone tz = TimeZone.CurrentTimeZone;

            X = Floor(3600 * X);
            h = Floor(X / 3600);
            mp = X - 3600 * h;
            m = Floor(mp / 60);
            ss = Floor(mp - 60 * m);
            if (m < 0) { h = h - 1; m = 60 + m; }
            if (ss < 0) { m = m - 1; ss = 60 + ss; }

            if (tz.IsDaylightSavingTime(DateTime.Now)) h += 1;


            if (h < 10) s = "0";
            else s = "";

            s = s + h.ToString() + ":";

            if (m < 0) m = 0;
            if (m < 10) s = s + "0";
            s = s + m.ToString();

            //if (ss < 10) s = s + "0";
            // s = s + ss.ToString();


            return s;
        }

        private double sind(double X)
        {
            return Math.Sin(PI / 180 * X);
        }
        private double cosd(double X)
        {
            return Math.Cos(PI / 180 * X);
        }
        private double tand(double X)
        {
            return Math.Tan(PI / 180 * X);
        }
        private double atand(double X)
        {
            return Math.Atan(X) * 180 / PI;
        }
        private double asind(double X)
        {
            return Math.Asin(X) * 180 / PI;
        }
        private double acosd(double X)
        {
            return Math.Acos(X) * 180 / PI;
        }
        private long Floor(double X)
        {
            return Convert.ToInt32(X);
        }
        private double ASin(double X)
        {
            return Math.Atan(X / Math.Sqrt(-X * X + 1.01));
        }
        private double ACos(double X)
        {
            return Math.Atan(-X / Math.Sqrt(-X * X + 1.01)) + 2 * Math.Atan(1);
        }

        private double ATan2(double X, double Y)
        {

            if (X == 0)

                if (Y == 0)
                    return 0;
                else if (Y > 0)
                    return PI / 2;
                else
                    return -PI / 2;

            else if (X > 0)
                if (Y == 0)
                    return 0;
                else
                    return Math.Atan(Y / X);

            else
                if (Y == 0)
                    return PI;
                else
                    return (PI - Math.Atan(Math.Abs(Y) / Math.Abs(X))) * Math.Sign(Y);

        }
        private double mod2(double a, double b)
        {
            return a - (b * Convert.ToInt32(a / b));
        }
        private void sun(double m1, double d1, double h, double lo)
        {
            double m2, l, lst, e, omega, ep, ed, u, v, theta, delta, alpha, ha, zr;
            long i;
            if (m1 < 7) d1 = 31 * (m1 - 1) + d1 + h / 24;
            else if (m1 >= 7) d1 = 6 + 30 * (m1 - 1) + d1 + h / 24;
            m2 = 74.2023 + 0.98560026 * d1;
            l = -2.75043 + 0.98564735 * d1;
            lst = 8.3162159 + 0.065709824 * Floor(d1) + 1.00273791 * 24 * mod2(d1, 1) + lo / 15;
            e = 0.0167065;
            omega = 4.85131 - 0.052954 * d1;
            ep = 23.4384717 + 0.00256 * cosd(omega);
            ed = 180 / PI * e;
            u = m2;
            for (i = 1; i <= 4; i++)
                u = u - (u - ed * sind(u) - m2) / (1 - e * cosd(u));

            v = 2 * atand(tand(u / 2) * Math.Sqrt((1 + e) / (1 - e)));
            theta = l + v - m2 - 0.00569 - 0.00479 * sind(omega);
            delta = asind(sind(ep) * sind(theta));

            alpha = 180 / PI * ATan2(cosd(theta), cosd(ep) * sind(theta));

            if (alpha >= 360) alpha = alpha - 360;
            ha = lst - alpha / 15;
            zr = rRound(h - ha, 24);

            XX = zr;
            YY = delta;

        }

        public string GetAzanSobh()
        {
            double m1 = month, d1 = day, lo = longitude, la = latitude, XX1, YY1, zr, delta, ha, t1;
            sun(m1, d1, 4, lo);
            XX1 = XX;
            YY1 = YY;
            zr = XX1;
            delta = YY1;
            ha = loc2hor(108, delta, la);
            t1 = rRound(zr - ha, 24);
            sun(m1, d1, t1, lo);
            zr = XX1;
            delta = YY1;
            ha = loc2hor(108, delta, la);
            t1 = rRound(zr - ha, 24);
            return hms(t1);
        }

        public string GetTolue()
        {
            double m1 = month, d1 = day, lo = longitude, la = latitude, XX1, YY1, zr, delta, ha, t2;
            sun(m1, d1, 6, lo);
            XX1 = XX;
            YY1 = YY;
            zr = XX1;
            delta = YY1;
            ha = loc2hor(90.833, delta, la);
            t2 = rRound(zr - ha, 24);
            sun(m1, d1, t2, lo);
            zr = XX1;
            delta = YY1;
            ha = loc2hor(90.833, delta, la);
            t2 = rRound(zr - ha, 24);
            return hms(t2);
        }

        public string GetAzanZohr()
        {
            double m1 = month, d1 = day, lo = longitude, la = latitude, XX1 = XX, zr;
            sun(m1, d1, 12, lo);
            sun(m1, d1, XX1, lo);
            zr = XX1;
            return hms(zr);
        }

        public string GetGhorub()
        {
            double m1 = month, d1 = day, lo = longitude, la = latitude, XX1 = XX, YY1 = YY, zr, delta, ha, t3;
            sun(m1, d1, 18, lo);
            zr = XX1;
            delta = YY1;
            ha = loc2hor(90.833, delta, la);
            t3 = rRound(zr + ha, 24);
            sun(m1, d1, t3, lo);
            zr = XX1;
            delta = YY1;
            ha = loc2hor(90.833, delta, la);
            t3 = rRound(zr + ha, 24);
            return hms(t3);
        }

        public string GetAzanMaghreb()
        {
            double m1 = month, d1 = day, lo = longitude, la = latitude, XX1 = XX, YY1 = YY, zr, delta, ha, t4;
            sun(m1, d1, 18.5, lo);
            zr = XX1;
            delta = YY1;
            ha = loc2hor(94.3, delta, la);
            t4 = rRound(zr + ha, 24);
            sun(m1, d1, t4, lo);
            zr = XX1;
            delta = YY1;
            ha = loc2hor(94.3, delta, la);
            t4 = rRound(zr + ha, 24);
            return hms(t4);
        }

        public string GetNimehShab()
        {
            TimeZone tz = TimeZone.CurrentTimeZone;
            double m1 = month, d1 = day, lo = longitude, la = latitude, XX1 = XX, zr;
            sun(m1, d1, 12, lo);
            sun(m1, d1, XX1, lo);
            zr = XX1;

            double h, mp, m, ss;
            string s = "";
            zr = Floor(3600 * zr);
            h = Floor(zr / 3600);
            mp = zr - 3600 * h;

            m = Floor(mp / 60);

            ss = Floor(mp - 60 * m);
            if (m < 0) { h = h - 1; m = 60 + m; }
            if (ss < 0) { m = m - 1; ss = 60 + ss; }
            if (m < 45) m += 15; else { h++; m = (m + 15) - 60; }

            if (tz.IsDaylightSavingTime(DateTime.Now)) h += 1;

            if ((h + 11) >= 24) s = "00:";
            else
            {
                if (h < 10) s = "0";
                else s = "";
                s = s + (h + 11).ToString() + ":";
            }
            if (m < 10) s = s + "0";
            s = s + m.ToString();

            //if (ss < 10) s = s + "0";
            // s = s + ss.ToString();
            return s;

        }

    }


//    public class PrayTime
//    {

//        //------------------------ Constants --------------------------

//        // Calculation Methods
//        public static int Jafari = 0;    // Ithna Ashari
//        public static int Karachi = 1;    // University of Islamic Sciences, Karachi
//        public static int ISNA = 2;    // Islamic Society of North America (ISNA)
//        public static int MWL = 3;    // Muslim World League (MWL)
//        public static int Makkah = 4;    // Umm al-Qura, Makkah
//        public static int Egypt = 5;    // Egyptian General Authority of Survey
//        public static int Custom = 6;    // Custom Setting
//        public static int Tehran = 7;    // Institute of Geophysics, University of Tehran

//        // Juristic Methods
//        public static int Shafii = 0;    // Shafii (standard)
//        public static int Hanafi = 1;    // Hanafi

//        // Adjusting Methods for Higher Latitudes
//        public static int None = 0;    // No adjustment
//        public static int MidNight = 1;    // middle of night
//        public static int OneSeventh = 2;    // 1/7th of night
//        public static int AngleBased = 3;    // angle/60th of night


//        // Time Formats
//        public static int Time24 = 0;    // 24-hour format
//        public static int Time12 = 1;    // 12-hour format
//        public static int Time12NS = 2;    // 12-hour format with no suffix
//        public static int Floating = 3;    // floating point number

//        // Time Names
//        public static String[] timeNames ={	"Fajr", "Sunrise", "Dhuhr", "Asr", "Sunset", "Maghrib",

//"Isha"};
//        static String InvalidTime = "----";	 // The string used for inv




//        //---------------------- Global Variables --------------------


//        private int calcMethod = 3;		// caculation method
//        private int asrJuristic;		// Juristic method for Asr
//        private int dhuhrMinutes = 0;		// minutes after mid-day for Dhuhr
//        private int adjustHighLats = 1;	// adjusting method for higher latitudes

//        private int timeFormat = 0;		// time format

//        private double lat;        // latitude
//        private double lng;        // longitude
//        private int timeZone;   // time-zone
//        private double JDate;      // Julian date

//        private int[] times;


//        //--------------------- Technical Settings --------------------


//        private int numIterations = 1;		// number of iterations needed to compute times



//        //------------------- Calc Method Parameters --------------------

//        private double[][] methodParams;
//        public PrayTime()
//        {
//            times = new int[7];
//            methodParams = new double[8][];
//            this.methodParams[Jafari] = new double[] { 16, 0, 4, 0, 14 };
//            this.methodParams[Karachi] = new double[] { 18, 1, 0, 0, 18 };
//            this.methodParams[ISNA] = new double[] { 15, 1, 0, 0, 15 };
//            this.methodParams[MWL] = new double[] { 18, 1, 0, 0, 17 };
//            this.methodParams[Makkah] = new double[] { 18.5, 1, 0, 1, 90 };
//            this.methodParams[Egypt] = new double[] { 19.5, 1, 0, 0, 17.5 };
//            this.methodParams[Tehran] = new double[] { 17.7, 0, 4.5, 0, 14 };
//            this.methodParams[Custom] = new double[] { 18, 1, 0, 0, 17 };
//        }






//        // return prayer times for a given date
//        public String[] getPrayerTimes(int year, int month, int day, double latitude, double longitude, int

//        timeZone)
//        {
//            return this.getDatePrayerTimes(year, month + 1, day, latitude, longitude, timeZone);
//        }

//        // set the calculation method
//        public void setCalcMethod(int methodID)
//        {
//            this.calcMethod = methodID;
//        }

//        // set the juristic method for Asr
//        public void setAsrMethod(int methodID)
//        {
//            if (methodID < 0 || methodID > 1)
//                return;
//            this.asrJuristic = methodID;
//        }

//        // set the angle for calculating Fajr
//        public void setFajrAngle(double angle)
//        {
//            this.setCustomParams(new int[] { (int)angle, -1, -1, -1, -1 });
//        }

//        // set the angle for calculating Maghrib
//        public void setMaghribAngle(double angle)
//        {
//            this.setCustomParams(new int[] { -1, 0, (int)angle, -1, -1 });
//        }

//        // set the angle for calculating Isha
//        public void setIshaAngle(double angle)
//        {
//            this.setCustomParams(new int[] { -1, -1, -1, 0, (int)angle });
//        }

//        // set the minutes after mid-day for calculating Dhuhr
//        public void setDhuhrMinutes(int minutes)
//        {
//            this.dhuhrMinutes = minutes;
//        }

//        // set the minutes after Sunset for calculating Maghrib
//        public void setMaghribMinutes(int minutes)
//        {
//            this.setCustomParams(new int[] { -1, 1, minutes, -1, -1 });
//        }

//        // set the minutes after Maghrib for calculating Isha
//        public void setIshaMinutes(int minutes)
//        {
//            this.setCustomParams(new int[] { -1, -1, -1, 1, minutes });
//        }

//        // set custom values for calculation parameters
//        public void setCustomParams(int[] param)
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                if (param[i] == -1)
//                    this.methodParams[Custom][i] = this.methodParams[this.calcMethod][i];
//                else
//                    this.methodParams[Custom][i] = param[i];
//            }
//            this.calcMethod = Custom;
//        }

//        // set adjusting method for higher latitudes
//        public void setHighLatsMethod(int methodID)
//        {
//            this.adjustHighLats = methodID;
//        }

//        // set the time format
//        public void setTimeFormat(int timeFormat)
//        {
//            this.timeFormat = timeFormat;
//        }

//        // convert float hours to 24h format
//        public String floatToTime24(double time)
//        {
//            if (time < 0)
//                return InvalidTime;
//            time = this.FixHour(time + 0.5 / 60);  // add 0.5 minutes to round
//            double hours = Math.Floor(time);
//            double minutes = Math.Floor((time - hours) * 60);
//            return this.twoDigitsFormat((int)hours) + ":" + this.twoDigitsFormat((int)minutes);
//        }

//        // convert float hours to 12h format
//        public String floatToTime12(double time, bool noSuffix)
//        {
//            if (time < 0)
//                return InvalidTime;
//            time = this.FixHour(time + 0.5 / 60);  // add 0.5 minutes to round
//            double hours = Math.Floor(time);
//            double minutes = Math.Floor((time - hours) * 60);
//            String suffix = hours >= 12 ? " pm" : " am";
//            hours = (hours + 12 - 1) % 12 + 1;
//            return ((int)hours) + ":" + this.twoDigitsFormat((int)minutes) + (noSuffix ? "" : suffix);
//        }

//        // convert float hours to 12h format with no suffix
//        public String floatToTime12NS(double time)
//        {
//            return this.floatToTime12(time, true);
//        }

//        //---------------------- Compute Prayer Times -----------------------


//        // return prayer times for a given date
//        public String[] getDatePrayerTimes(int year, int month, int day, double latitude, double longitude,

//        int timeZone)
//        {
//            this.lat = latitude;
//            this.lng = longitude;
//            this.timeZone = timeZone;
//            this.JDate = this.JulianDate(year, month, day) - longitude / (15 * 24);

//            return this.computeDayTimes();
//        }

//        // compute declination angle of sun and equation of time
//        public double[] sunPosition(double jd)
//        {
//            double D = jd - 2451545.0;
//            double g = this.FixAngle(357.529 + 0.98560028 * D);
//            double q = this.FixAngle(280.459 + 0.98564736 * D);
//            double L = this.FixAngle(q + 1.915 * this.dsin(g) + 0.020 * this.dsin(2 * g));

//            double R = 1.00014 - 0.01671 * this.dcos(g) - 0.00014 * this.dcos(2 * g);
//            double e = 23.439 - 0.00000036 * D;

//            double d = this.darcsin(this.dsin(e) * this.dsin(L));
//            double RA = this.darctan2(this.dcos(e) * this.dsin(L), this.dcos(L)) / 15;
//            RA = this.FixHour(RA);
//            double EqT = q / 15 - RA;

//            return new double[] { d, EqT };
//        }

//        // compute equation of time
//        public double equationOfTime(double jd)
//        {
//            return this.sunPosition(jd)[1];
//        }

//        // compute declination angle of sun
//        public double sunDeclination(double jd)
//        {
//            return this.sunPosition(jd)[0];
//        }

//        // compute mid-day (Dhuhr, Zawal) time
//        public double computeMidDay(double t)
//        {
//            double T = this.equationOfTime(this.JDate + t);
//            double Z = this.FixHour(12 - T);
//            return Z;
//        }

//        // compute time for a given angle G
//        public double computeTime(double G, double t)
//        {
//            //System.out.println("G: "+G);

//            double D = this.sunDeclination(this.JDate + t);
//            double Z = this.computeMidDay(t);
//            double V = ((double)1 / 15) * this.darccos((-this.dsin(G) - this.dsin(D) * this.dsin(this.lat)) /
//                    (this.dcos(D) * this.dcos(this.lat)));
//            return Z + (G > 90 ? -V : V);
//        }

//        // compute the time of Asr
//        public double computeAsr(int step, double t)  // Shafii: step=1, Hanafi: step=2
//        {
//            double D = this.sunDeclination(this.JDate + t);
//            double G = -this.darccot(step + this.dtan(Math.Abs(this.lat - D)));
//            return this.computeTime(G, t);
//        }

//        //---------------------- Compute Prayer Times -----------------------

//        // compute prayer times at given julian date
//        public double[] computeTimes(double[] times)
//        {
//            double[] t = this.dayPortion(times);


//            double Fajr = this.computeTime(180 - this.methodParams[this.calcMethod][0], t[0]);
//            double Sunrise = this.computeTime(180 - 0.833, t[1]);
//            double Dhuhr = this.computeMidDay(t[2]);
//            double Asr = this.computeAsr(1 + this.asrJuristic, t[3]);
//            double Sunset = this.computeTime(0.833, t[4]); ;
//            double Maghrib = this.computeTime(this.methodParams[this.calcMethod][2], t[5]);
//            double Isha = this.computeTime(this.methodParams[this.calcMethod][4], t[6]);

//            return new double[] { Fajr, Sunrise, Dhuhr, Asr, Sunset, Maghrib, Isha };
//        }

//        // adjust Fajr, Isha and Maghrib for locations in higher latitudes
//        public double[] adjustHighLatTimes(double[] times)
//        {
//            double nightTime = this.GetTimeDifference(times[4], times[1]); // sunset to sunrise

//            // Adjust Fajr
//            double FajrDiff = this.nightPortion(this.methodParams[this.calcMethod][0]) * nightTime;
//            if (this.GetTimeDifference(times[0], times[1]) > FajrDiff)
//                times[0] = times[1] - FajrDiff;

//            // Adjust Isha
//            double IshaAngle = (this.methodParams[this.calcMethod][3] == 0) ? this.methodParams

//        [this.calcMethod][4] : 18;
//            double IshaDiff = this.nightPortion(IshaAngle) * nightTime;
//            if (this.GetTimeDifference(times[4], times[6]) > IshaDiff)
//                times[6] = times[4] + IshaDiff;

//            // Adjust Maghrib
//            double MaghribAngle = (methodParams[this.calcMethod][1] == 0) ? this.methodParams

//        [this.calcMethod][2] : 4;
//            double MaghribDiff = this.nightPortion(MaghribAngle) * nightTime;
//            if (this.GetTimeDifference(times[4], times[5]) > MaghribDiff)
//                times[5] = times[4] + MaghribDiff;

//            return times;
//        }

//        // the night portion used for adjusting times in higher latitudes
//        public double nightPortion(double angle)
//        {
//            double val = 0;
//            if (this.adjustHighLats == AngleBased)
//                val = 1.0 / 60.0 * angle;
//            if (this.adjustHighLats == MidNight)
//                val = 1.0 / 2.0;
//            if (this.adjustHighLats == OneSeventh)
//                val = 1.0 / 7.0;

//            return val;
//        }

//        public double[] dayPortion(double[] times)
//        {
//            for (int i = 0; i < times.Length; i++)
//            {
//                times[i] /= 24;
//            }
//            return times;
//        }

//        // compute prayer times at given julian date
//        public String[] computeDayTimes()
//        {
//            double[] times = { 5, 6, 12, 13, 18, 18, 18 }; //default times

//            for (int i = 0; i < this.numIterations; i++)
//            {
//                times = this.computeTimes(times);
//            }

//            times = this.adjustTimes(times);
//            return this.adjustTimesFormat(times);
//        }


//        // adjust times in a prayer time array
//        public double[] adjustTimes(double[] times)
//        {
//            for (int i = 0; i < 7; i++)
//            {
//                times[i] += this.timeZone - this.lng / 15;
//            }
//            times[2] += this.dhuhrMinutes / 60; //Dhuhr
//            if (this.methodParams[this.calcMethod][1] == 1) // Maghrib
//                times[5] = times[4] + this.methodParams[this.calcMethod][2] / 60.0;
//            if (this.methodParams[this.calcMethod][3] == 1) // Isha
//                times[6] = times[5] + this.methodParams[this.calcMethod][4] / 60.0;

//            if (this.adjustHighLats != None)
//            {
//                times = this.adjustHighLatTimes(times);
//            }

//            return times;
//        }

//        public String[] adjustTimesFormat(double[] times)
//        {
//            String[] formatted = new String[times.Length];

//            if (this.timeFormat == Floating)
//            {
//                for (int i = 0; i < times.Length; ++i)
//                {
//                    formatted[i] = times[i] + "";
//                }
//                return formatted;
//            }
//            for (int i = 0; i < 7; i++)
//            {
//                if (this.timeFormat == Time12)
//                    formatted[i] = this.floatToTime12(times[i], true);
//                else if (this.timeFormat == Time12NS)
//                    formatted[i] = this.floatToTime12NS(times[i]);
//                else
//                    formatted[i] = this.floatToTime24(times[i]);
//            }
//            return formatted;
//        }

//        //---------------------- Misc Functions -----------------------

//        // compute the difference between two times
//        public double GetTimeDifference(double c1, double c2)
//        {
//            double diff = this.FixHour(c2 - c1); ;
//            return diff;
//        }

//        // add a leading 0 if necessary
//        public String twoDigitsFormat(int num)
//        {

//            return (num < 10) ? "0" + num : num + "";
//        }

//        //---------------------- Julian Date Functions -----------------------

//        // calculate julian date from a calendar date
//        public double JulianDate(int year, int month, int day)
//        {
//            if (month <= 2)
//            {
//                year -= 1;
//                month += 12;
//            }
//            double A = (double)Math.Floor(year / 100.0);
//            double B = 2 - A + Math.Floor(A / 4);

//            double JD = Math.Floor(365.25 * (year + 4716)) + Math.Floor(30.6001 * (month + 1)) + day + B - 1524.5;
//            return JD;
//        }


//        //---------------------- Time-Zone Functions -----------------------


//        // detect daylight saving in a given date
//        public bool UseDayLightaving(int year, int month, int day)
//        {
//            return TimeZone.CurrentTimeZone.IsDaylightSavingTime(new DateTime(year, month, day));
//        }

//        // ---------------------- Trigonometric Functions -----------------------

//        // degree sin
//        public double dsin(double d)
//        {
//            return Math.Sin(this.DegreeToRadian(d));
//        }

//        // degree cos
//        public double dcos(double d)
//        {
//            return Math.Cos(this.DegreeToRadian(d));
//        }

//        // degree tan
//        public double dtan(double d)
//        {
//            return Math.Tan(this.DegreeToRadian(d));
//        }

//        // degree arcsin
//        public double darcsin(double x)
//        {
//            return this.RadianToDegree(Math.Asin(x));
//        }

//        // degree arccos
//        public double darccos(double x)
//        {
//            return this.RadianToDegree(Math.Acos(x));
//        }

//        // degree arctan
//        public double darctan(double x)
//        {
//            return this.RadianToDegree(Math.Atan(x));
//        }

//        // degree arctan2
//        public double darctan2(double y, double x)
//        {
//            return this.RadianToDegree(Math.Atan2(y, x));
//        }

//        // degree arccot
//        public double darccot(double x)
//        {
//            return this.RadianToDegree(Math.Atan(1 / x));
//        }


//        // Radian to Degree
//        public double RadianToDegree(double radian)
//        {
//            return (radian * 180.0) / Math.PI;
//        }

//        // degree to radian
//        public double DegreeToRadian(double degree)
//        {
//            return (degree * Math.PI) / 180.0;
//        }

//        public double FixAngle(double angel)
//        {
//            angel = angel - 360.0 * (Math.Floor(angel / 360.0));
//            angel = angel < 0 ? angel + 360.0 : angel;
//            return angel;
//        }

//        // range reduce hours to 0..23
//        public double FixHour(double hour)
//        {
//            hour = hour - 24.0 * (Math.Floor(hour / 24.0));
//            hour = hour < 0 ? hour + 24.0 : hour;
//            return hour;
//        }
//    }

}