using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
//Author : phvankhoa@gmail.com
public class vkGroupBox2Cham0 : GroupBox
{
    public enum CanhChieuNgang1
    {
        Trai,
        Giua,
        Phai
    }
    private const int trNhanPadding = 6;
    private const int trNhanMargin = 13;
    private const int trKtBoGoc = 3;
    private CanhChieuNgang1 trCanhChieuNgang = CanhChieuNgang1.Giua;
    private Color trMauVien = Color.CadetBlue;
    private Color trMauNenNhan = Color.Transparent;
    private bool trBoGoc = true;
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        //MyBase.OnPaint(e)
        Graphics bGraphics = e.Graphics;
        int bDoCaoDong = 0;
        bDoCaoDong = (int)Font.Size;
        Rectangle bRect = ClientRectangle;
        bRect.Y += bDoCaoDong / 2;
        bRect.Height -= bDoCaoDong / 2;
        bRect.Size -= new Size(1, 1);
        GraphicsPath bGraphPath = new GraphicsPath();
        RectangleF bRect2 = new RectangleF(trNhanMargin, 0, ClientSize.Width - 2 * trNhanMargin, bDoCaoDong * 10);
        StringFormat bStringFormat = new StringFormat();
        switch (trCanhChieuNgang)
        {
            case CanhChieuNgang1.Trai:
                bStringFormat.Alignment = StringAlignment.Near;
                break;
            case CanhChieuNgang1.Giua:
                bStringFormat.Alignment = StringAlignment.Center;
                break;
            case CanhChieuNgang1.Phai:
                bStringFormat.Alignment = StringAlignment.Far;
                break;
        }
        bGraphPath.AddString(Text, Font.FontFamily, (int)Font.Style, Font.Size, bRect2, bStringFormat);
        bRect2 = bGraphPath.GetBounds();
        bRect2.Inflate(trNhanPadding, trNhanPadding);
        Region bRegion = new Region(ClientRectangle);
        bRegion.Exclude(bRect2);
        bGraphics.Clip = bRegion;
        if (trBoGoc)
        {
            bGraphics.DrawPath(new Pen(trMauVien, 1), ChuNhatBoGoc(bRect));
        }
        else
        {
            bGraphics.DrawRectangle(new Pen(trMauVien, 1), bRect);
        }
        bGraphics.ResetClip();
        if (trMauNenNhan != Color.Transparent)
        {
            bGraphics.FillRectangle(new SolidBrush(trMauNenNhan), bRect2);
        }
        bGraphics.SmoothingMode = SmoothingMode.AntiAlias;
        bGraphics.FillPath(new SolidBrush(ForeColor), bGraphPath);
    }
    private GraphicsPath ChuNhatBoGoc(Rectangle tsChuNhat)
    {
        if (trKtBoGoc <= 0)
        {
            throw new ArgumentException("Kích thước bo góc phải lớn hơn 0");
        }
        else
        {
            Point[] bCacDiem = new Point[8];
            // ERROR: Not supported in C#: ReDimStatement

            bCacDiem[0] = new Point(tsChuNhat.Left, tsChuNhat.Top + trKtBoGoc);
            bCacDiem[1] = new Point(tsChuNhat.Left + trKtBoGoc, tsChuNhat.Top);
            bCacDiem[2] = new Point(tsChuNhat.Right - trKtBoGoc, tsChuNhat.Top);
            bCacDiem[3] = new Point(tsChuNhat.Right, tsChuNhat.Top + trKtBoGoc);
            bCacDiem[4] = new Point(tsChuNhat.Right, tsChuNhat.Bottom - trKtBoGoc);
            bCacDiem[5] = new Point(tsChuNhat.Right - trKtBoGoc, tsChuNhat.Bottom);
            bCacDiem[6] = new Point(tsChuNhat.Left + trKtBoGoc, tsChuNhat.Bottom);
            bCacDiem[7] = new Point(tsChuNhat.Left, tsChuNhat.Bottom - trKtBoGoc);
            GraphicsPath bGraphPath = new GraphicsPath();
            bGraphPath.AddPolygon(bCacDiem);
            return bGraphPath;
        }
    }
    [Description("Canh chiều ngang"), Category("vkGroupBox")]
    public CanhChieuNgang1 CanhChieuNgang
    {
        get { return trCanhChieuNgang; }
        set
        {
            trCanhChieuNgang = value;
            Invalidate();
        }
    }
    [Description("Màu viền"), Category("vkGroupBox")]
    public Color MauVien
    {
        get { return trMauVien; }
        set
        {
            trMauVien = value;
            Invalidate();
        }
    }
    [Description("Màu nền nhãn"), Category("vkGroupBox")]
    public Color MauNenNhan
    {
        get { return trMauNenNhan; }
        set
        {
            trMauNenNhan = value;
            Invalidate();
        }
    }
    [Description("Bo góc"), Category("vkGroupBox")]
    public bool BoGoc
    {
        get { return trBoGoc; }
        set
        {
            trBoGoc = value;
            Invalidate();
        }
    }
}
//Author : phvankhoa@gmail.com

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================

