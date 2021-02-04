using Microsoft.Toolkit.Uwp.UI.Lottie.LottieData;
using Microsoft.Toolkit.Uwp.UI.Lottie.LottieData.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace myLottie {
    public partial class Form1 : Form {
        LottieComposition lottieComposition;
        public Form1() {
            InitializeComponent();
            IReadOnlyList<(string Code, string Description)>? _readerIssues;
            FileStream jsonStream = File.OpenRead("test2.json");
            lottieComposition = LottieCompositionReader.ReadLottieCompositionFromJsonStream(
           jsonStream,
           LottieCompositionReader.Options.IgnoreMatchNames,
           out _readerIssues);
            propertyGrid1.SelectedObject = lottieComposition;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
