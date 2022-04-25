using System;
using System.Drawing;

namespace MiniGame.Cls
{
    public class ClsSlideshow
    {
        //縦横比を保ったまま、拡大縮小する
        public Image ScalingImage(Image image, int w, int h)
        {
            Bitmap canvas = new Bitmap(w, h);

            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, w, h);

            float fw = (float)w / (float)image.Width;
            float fh = (float)h / (float)image.Height;

            float scale = Math.Min(fw, fh);
            fw = image.Width * scale;
            fh = image.Height * scale;

            g.DrawImage(image, (w - fw) / 2, (h - fh) / 2, fw, fh);
            g.Dispose();

            return canvas;
        }

        public ClsSetting readXML(string filePath)
        {
            System.IO.StreamReader sr = null;

            try
            {
                //XmlSerializerオブジェクトを作成
                System.Xml.Serialization.XmlSerializer serializer =
                    new System.Xml.Serialization.XmlSerializer(typeof(ClsSetting));

                //読み込むファイルを開く
                sr = new System.IO.StreamReader(filePath, new System.Text.UTF8Encoding(false));

                //XMLファイルから読み込む、逆シリアル化する
                ClsSetting obj = (ClsSetting)serializer.Deserialize(sr);

                obj.ToStringValue();

                return obj;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                if (sr != null)
                {
                    //ファイルを閉じる
                    sr.Close();
                }
            }
        }
    }
}
