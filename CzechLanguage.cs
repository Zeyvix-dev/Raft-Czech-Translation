using RaftModLoader;
using UnityEngine;
using HMLLibrary;
using I2.Loc;
using System.Text;

public class CzechLanguage : Mod
{
    public void Start()
    {
        string csv = Encoding.UTF8.GetString(
            GetEmbeddedFileBytes("Loc.csv")
        );

        Debug.Log(
            LocalizationManager.Sources[0].Import_CSV(
                null,
                csv,
                eSpreadsheetUpdateMode.Merge,
                ';'
            )
        );

        LocalizationManager.LocalizeAll(true);
        Log("Czech language loaded!");
    }
}