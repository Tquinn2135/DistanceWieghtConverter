using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class DistancePage : ContentPage
{
    private double KeyValue = 0;

    private double dbl_m2f = 3.280839895;
    private double dbl_m2i = 39.37007874;
    private double dbl_m2mi = 0.00062137119;
    private double dbl_m2m = 1;
    private double dbl_m2nm = 0.0005399568034557;
    private double dbl_m2y = 1.093613298;
    private double dbl_m2k = 0.001;
    
    
    public DistancePage()
    {
        InitializeComponent();
        Title = "Distance Converter";

        ToolbarItem tbi = new ToolbarItem();
        tbi.Text = "About";
        this.ToolbarItems.Add(tbi);

        tbi.Clicked += delegate
        {
            Navigation.PushAsync(new AboutPage());
        };
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtFeet.Text = "";
        txtInches.Text = "";
        txtMeters.Text = "";
        txtMiles.Text = "";
        txtNautical.Text = "";
        txtYards.Text = "";
        txtKiloMeters.Text = "";
    }
    
    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtFeet.Text = (KeyValue * dbl_m2f).ToString("g9");
        txtInches.Text = (KeyValue * dbl_m2i).ToString("g9");
        txtMeters.Text = (KeyValue * dbl_m2m).ToString("g9");
        txtMiles.Text = (KeyValue * dbl_m2mi).ToString("g9");
        txtNautical.Text = (KeyValue * dbl_m2nm).ToString("g9");
        txtYards.Text = (KeyValue * dbl_m2y).ToString("g9");
        txtKiloMeters.Text = (KeyValue * dbl_m2k).ToString("g9");
    }

    private void TxtMeters_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2m convert
        double dblNumber;
        var isvalid = Double.TryParse(txtMeters.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2m;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtInches_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2i convert
        double dblNumber;
        var isvalid = Double.TryParse(txtInches.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2i;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtFeet_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2f convert
        double dblNumber;
        var isvalid = Double.TryParse(txtFeet.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2f;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtYards_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2y convert
        double dblNumber;
        var isvalid = Double.TryParse(txtYards.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2y;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtMiles_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2mi convert
        double dblNumber;
        var isvalid = Double.TryParse(txtMiles.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2mi;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtNautical_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2nm convert
        double dblNumber;
        var isvalid = Double.TryParse(txtNautical.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2nm;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKiloMeters_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //m2y convert
        double dblNumber;
        var isvalid = Double.TryParse(txtYards.Text, out dblNumber);

        if (isvalid && dblNumber !=0)
        {
            KeyValue = dblNumber / dbl_m2y;
        }
        else
        {
            KeyValue = 0;
        }
    }
}