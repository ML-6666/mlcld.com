using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using CommonData;
using System.Data;


/*------------Common Class For Property-------------------*/
/*--------------------------------------------------------*/
public class Common
{
    /*------Property of Country Table-----------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/

    public string cps
    {
        get;
        set;
    }
    public string CountryId
    {
        get;
        set;
    }
    public string CountryName
    {
        get;
        set;
    }
    public string CountryDescription
    {
        get;
        set;
    }

    /*------Property of Shape Table-------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string ShapeId
    {
        get;
        set;
    }
    public string ShapeName
    {
        get;
        set;
    }
    public string ShapeImage
    {
        get;
        set;
    }
    public string ShapeDescription
    {
        get;
        set;
    }
    /*------Property of Color Table-------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string ColorId
    {
        get;
        set;
    }
    public string ColorName
    {
        get;
        set;
    }
    public string ColorDescription
    {
        get;
        set;
    }

    /*------Property of Clarity Table-----------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string ClarityId
    {
        get;
        set;
    }
    public string ClarityName
    {
        get;
        set;
    }
    public string ClarityDescription
    {
        get;
        set;
    }
    /*------Property of Cut Table---------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string CutId
    {
        get;
        set;
    }
    public string CutName
    {
        get;
        set;
    }
    public string CutDescription
    {
        get;
        set;
    }
    /*------Property of Symmetry Table----------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string SymmetryId
    {
        get;
        set;
    }
    public string SymmetryName
    {
        get;
        set;
    }
    public string SymmetryDescription
    {
        get;
        set;
    }
    /*------Property of Polish Table-----------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string PolishId
    {
        get;
        set;
    }
    public string PolishName
    {
        get;
        set;
    }
    public string PolishDescription
    {
        get;
        set;
    }

    /*------Property of Weight Table---------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string WeightId
    {
        get;
        set;
    }
    public string WeightName
    {
        get;
        set;
    }
    public string WeightDescription
    {
        get;
        set;
    }

    /*------Property of Fluorescence Table------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string FluorescenceId
    {
        get;
        set;
    }
    public string FluorescenceName
    {
        get;
        set;
    }
    public string FluorescenceDescription
    {
        get;
        set;
    }
    /*------Property of Certification Table-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string CertificationId
    {
        get;
        set;
    }
    public string CertificationName
    {
        get;
        set;
    }
    public string CertificationDescription
    {
        get;
        set;
    }

    /*------Property of Inclusion Table---------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string InclusionId
    {
        get;
        set;
    }
    public string InclusionName
    {
        get;
        set;
    }
    public string InclusionDescription
    {
        get;
        set;
    }

    /*------Property of Lustre Table------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string LustreId
    {
        get;
        set;
    }
    public string LustreName
    {
        get;
        set;
    }
    public string LustreDescription
    {
        get;
        set;
    }

    /*------Property of Scintillation Table-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string ScintillationId
    {
        get;
        set;
    }
    public string ScintillationName
    {
        get;
        set;
    }
    public string ScintillationDescription
    {
        get;
        set;
    }

    /*------Property of State Table-------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string StateId
    {
        get;
        set;
    }
    public string StateName
    {
        get;
        set;
    }
    public string StateDescription
    {
        get;
        set;
    }

    /*------Property of City Table--------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string CityId
    {
        get;
        set;
    }
    public string CityName
    {
        get;
        set;
    }
    public string CityDescription
    {
        get;
        set;
    }
    /*------Property of Lot Table---------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string LotId
    {
        get;
        set;
    }
    public string LotName
    {
        get;
        set;
    }
    public string LotDescription
    {
        get;
        set;
    }

    /*------Property of RapRate Table-----------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string RapRateId
    {
        get;
        set;
    }
    public string RapRateName
    {
        get;
        set;
    }

    /*------Property of RapRate Table-----------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string DID
    {
        get;
        set;
    }
    public string DiamondStatus
    {
        get;
        set;
    }
    public string Remark
    {
        get;
        set;
    }
    public string CertificationNo
    {
        get;
        set;
    }
    public string CertificationURL
    {
        get;
        set;
    }
    public string CertificationImage
    {
        get;
        set;
    }
    public string DWeight
    {
        get;
        set;
    }
    public string DTablePer
    {
        get;
        set;
    }
    public string DDiameter
    {
        get;
        set;
    }
    public string DTotalDepthIn
    {
        get;
        set;
    }
    public string DTotalDepthPer
    {
        get;
        set;
    }
    public string DCrownHightIn
    {
        get;
        set;
    }
    public string DCrownHightPer
    {
        get;
        set;
    }
    public string DPavelionDepthIn
    {
        get;
        set;
    }
    public string DPavelionDepthPer
    {
        get;
        set;
    }
    public string DGridleThickness
    {
        get;
        set;
    }
    public string DCulet
    {
        get;
        set;
    }
    public string DDiscount
    {
        get;
        set;
    }
    public string DSellingPrice
    {
        get;
        set;
    }
    public string DDiscription
    {
        get;
        set;
    }
    public string DiamondImage1
    {
        get;
        set;
    }
    public string DiamondImage2
    {
        get;
        set;
    }

    /*------Property of ClubMemberInfo Table----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string MID
    {
        get;
        set;
    }
    public string CName
    {
        get;
        set;
    }
    public string PName
    {
        get;
        set;
    }
    public string CAddress
    {
        get;
        set;
    }
    public string RegistrationNo
    {
        get;
        set;
    }
    public string RegNo
    {
        get;
        set;
    }
    public string PanCardNo
    {
        get;
        set;
    }
    public string PanNo
    {
        get;
        set;
    }
    public string EmailId
    {
        get;
        set;
    }
    public string MobileNo
    {
        get;
        set;
    }

    /*------Property of Diamond Pair Table------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string PFrom
    {
        get;
        set;
    }
    public string PTo
    {
        get;
        set;
    }
    /*------Property of Diamond Near Pair Table-------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string NPFrom
    {
        get;
        set;
    }
    public string NPTo
    {
        get;
        set;
    }


    /*------Property of LooseDiamond Table----------------------------------------------------------*/
    public int MembersDiscount { get; set; }
    public string Membertype { get; set; }
    public string DiamondType { get; set; }

    /*------Property of Advance Search Table----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string ASID
    {
        get;
        set;
    }
    public string ASName
    {
        get;
        set;
    }
    public string ASContact
    {
        get;
        set;
    }
    public string ASEmail
    {
        get;
        set;
    }
    public string AComment
    {
        get;
        set;
    }
    public string ASearch
    {
        get;
        set;
    }

    /*------Property of LotNumber Info Table----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string LotNumberId
    {
        get;
        set;
    }
    public string OwnerName
    {
        get;
        set;
    }
    public string OwnerAddress
    {
        get;
        set;
    }
    public string ReceivedPlace
    {
        get;
        set;
    }
    public string ReceivedPerson
    {
        get;
        set;
    }
    public string LotRemark
    {
        get;
        set;
    }

    /*------Property of PDiamond Request Table--------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public string PDRID
    {
        get;
        set;
    }
    public string PDName
    {
        get;
        set;
    }
    public string PContact
    {
        get;
        set;
    }
    public string PEmail
    {
        get;
        set;
    }
    public string PShape
    {
        get;
        set;
    }
    public string PWeight
    {
        get;
        set;
    }
    public string PColor
    {
        get;
        set;
    }
    public string PClarity
    {
        get;
        set;
    }
    public string PComment
    {
        get;
        set;
    }

    /*------Property of Membership---------------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public int MemberID { get; set; }
    public string MemberName { get; set; }
    public string EmailID { get; set; }
    public string MemberPassword { get; set; }


}

/*------------Common Class For Function-------------------*/
/*--------------------------------------------------------*/
public class CommonModule
{
    /*------------Function member admin --------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/


    public static DataTable getMemberData(Common c)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@EmailID", c.EmailID.ToString().Trim()), 
                                
                                };


            DataTable resultval = DB.ExecuteQueryByProc("SP_GetDetailsClubMemberInfo", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }

    }

    public static DataTable Memberdetails(int MID)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@MID", MID), 
                                
                                };


            DataTable resultval = DB.ExecuteQueryByProc("SP_MLCD_ClubMemberInfo_GetALLMemberByID", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }
    public static DataTable getCertificateImage(int MID)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@dId", MID), 
                                
                                };


            DataTable resultval = DB.ExecuteQueryByProc("SP_GetLooseDiamondImage", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }
    public static DataTable MemberLoginCount(int MID)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@MID", MID), 
                                
                                };


            DataTable resultval = DB.ExecuteQueryByProc("SP_MLCD_loginCount_Get", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }


    public static int loginCount(string MID, int logincounter)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@MID", MID), 
                                 new SqlParameter("@LoginCount", logincounter)
                                };


            int resultval = DB.ExecuteNonQueryByProc("SP_MLCD_loginCount", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }

    public static DataTable MemberActive(int MID)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@MID", MID), 
                                
                                };


            DataTable resultval = DB.ExecuteQueryByProc("SP_MLCD_ClubMemberInfo_activate", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }

    /*------------Function Formember function --------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static int updateMember(string Emailid, string oldPassword, string newPassword)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@EmailID", Emailid), 
                                new SqlParameter("@oldpassword", oldPassword),
                                new SqlParameter("@newPassword", newPassword) };


            int resultval = (int)DB.ExecuteScalervalue("SP_MLCD_ClubMemberInfo_UpdatePassw", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }
    public static string forgotpassword(string Emailid)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@EmailID", Emailid) 
 };


            string resultval = (string)DB.ExecuteScalervalue("SP_MLCD_ClubMemberInfo_forgotpass", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }
    public static string getUserName(string Emailid)
    {
        try
        {


            SqlParameter[] parm = { new SqlParameter("@EmailID", Emailid) 
 };


            string resultval = (string)DB.ExecuteScalervalue("SP_MLCD_ClubMemberInfo_getUserName", parm);
            return resultval;
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }

    /*------------Function For Insert Country --------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertCountry(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CountryName",c.CountryName),
                                new SqlParameter("@CountryDescription",c.CountryDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertCountryMast", param);
            return "Thankyou! Country Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertCountry";
        }
    }

    /*------------Function For Update Country---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateCountry(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CountryId",c.CountryId),
                                new SqlParameter("@CountryName",c.CountryName),
                                new SqlParameter("@CountryDescription",c.CountryDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateCountryMast", param);
            return "Thankyou! Country Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateCountry";
        }
    }

    /*------------Function For Delete Country---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteCountry(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CountryId",c.CountryId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteCountryMast", param);
            return "Thankyou! Country Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteCountry";
        }
    }

    /*------------Function For Insert Shape ----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertShape(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ShapeName",c.ShapeName),
                                new SqlParameter("@ShapeImage",c.ShapeImage),
                                new SqlParameter("@ShapeDescription",c.ShapeDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertShapeMast", param);
            return "Thankyou! Shape Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertShape";
        }
    }

    /*------------Function For Update Shape-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateShape(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ShapeId",c.ShapeId),
                                new SqlParameter("@ShapeName",c.ShapeName),
                                new SqlParameter("@ShapeImage",c.ShapeImage),
                                new SqlParameter("@ShapeDescription",c.ShapeDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateShapeMast", param);
            return "Thankyou! Shape Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateShape";
        }
    }

    /*------------Function For Delete Shape-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteShape(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ShapeId",c.ShapeId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteShapeMast", param);
            return "Thankyou! Shape Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteShape";
        }
    }
    /*------------Function For Insert Color ----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertColor(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ColorName",c.ColorName),
                                new SqlParameter("@ColorDescription",c.ColorDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertColorMast", param);
            return "Thankyou! Color Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertColor";
        }
    }

    /*------------Function For Update Color-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateColor(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ColorId",c.ColorId),
                                new SqlParameter("@ColorName",c.ColorName),
                                new SqlParameter("@ColorDescription",c.ColorDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateColorMast", param);
            return "Thankyou! Color Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateColor";
        }
    }

    /*------------Function For Delete Color-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteColor(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ColorId",c.ColorId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteColorMast", param);
            return "Thankyou! Color Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteColor";
        }
    }

    /*------------Function For Insert Clarity --------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertClarity(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ClarityName",c.ClarityName),
                                new SqlParameter("@ClarityDescription",c.ClarityDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertClarityMast", param);
            return "Thankyou! Clarity Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertClarity";
        }
    }

    /*------------Function For Update Clarity---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateClarity(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ClarityId",c.ClarityId),
                                new SqlParameter("@ClarityName",c.ClarityName),
                                new SqlParameter("@ClarityDescription",c.ClarityDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateClarityMast", param);
            return "Thankyou! Clarity Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateClarity";
        }
    }

    /*------------Function For Delete Clarity---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteClarity(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ClarityId",c.ClarityId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteClarityMast", param);
            return "Thankyou! Clarity Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteClarity";
        }
    }

    /*------------Function For Insert Cut ------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertCut(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CutName",c.CutName),
                                new SqlParameter("@CutDescription",c.CutDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertCutMast", param);
            return "Thankyou! Cut Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertCut";
        }
    }

    /*------------Function For Update Cut-------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateCut(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CutId",c.CutId),
                                new SqlParameter("@CutName",c.CutName),
                                new SqlParameter("@CutDescription",c.CutDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateCutMast", param);
            return "Thankyou! Cut Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateCut";
        }
    }

    /*------------Function For Delete Cut-------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteCut(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CutId",c.CutId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteCutMast", param);
            return "Thankyou! Cut Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteCut";
        }
    }

    /*------------Function For Insert Symmetry -------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertSymmetry(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@SymmetryName",c.SymmetryName),
                                new SqlParameter("@SymmetryDescription",c.SymmetryDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertSymmetryMast", param);
            return "Thankyou! Symmetry Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertSymmetry";
        }
    }

    /*------------Function For Update Symmetry--------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateSymmetry(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@SymmetryId",c.SymmetryId),
                                new SqlParameter("@SymmetryName",c.SymmetryName),
                                new SqlParameter("@SymmetryDescription",c.SymmetryDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateSymmetryMast", param);
            return "Thankyou! Symmetry Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateSymmetry";
        }
    }

    /*------------Function For Delete Symmetry--------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteSymmetry(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@SymmetryId",c.SymmetryId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteSymmetryMast", param);
            return "Thankyou! Symmetry Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteSymmetry";
        }
    }

    /*------------Function For Insert Polish ---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertPolish(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@PolishName",c.PolishName),
                                new SqlParameter("@PolishDescription",c.PolishDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertPolishMast", param);
            return "Thankyou! Polish Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertPolish";
        }
    }

    /*------------Function For Update Polish----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdatePolish(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@PolishId",c.PolishId),
                                new SqlParameter("@PolishName",c.PolishName),
                                new SqlParameter("@PolishDescription",c.PolishDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdatePolishMast", param);
            return "Thankyou! Polish Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdatePolish";
        }
    }

    /*------------Function For Delete Polish----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeletePolish(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@PolishId",c.PolishId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeletePolishMast", param);
            return "Thankyou! Polish Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeletePolish";
        }
    }

    /*------------Function For Insert Weight ---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertWeight(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@WeightName",c.WeightName),
                                new SqlParameter("@WeightDescription",c.WeightDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertWeightMast", param);
            return "Thankyou! Weight Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertWeight";
        }
    }

    /*------------Function For Update Weight----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateWeight(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@WeightId",c.WeightId),
                                new SqlParameter("@WeightName",c.WeightName),
                                new SqlParameter("@WeightDescription",c.WeightDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateWeightMast", param);
            return "Thankyou! Weight Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateWeight";
        }
    }

    /*------------Function For Delete Weight----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteWeight(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@WeightId",c.WeightId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteWeightMast", param);
            return "Thankyou! Weight Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteWeight";
        }
    }

    /*------------Function For Insert Fluorescence ---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertFluorescence(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@FluorescenceName",c.FluorescenceName),
                                new SqlParameter("@FluorescenceDescription",c.FluorescenceDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertFluorescenceMast", param);
            return "Thankyou! Fluorescence Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertFluorescence";
        }
    }

    /*------------Function For Update Fluorescence----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateFluorescence(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@FluorescenceId",c.FluorescenceId),
                                new SqlParameter("@FluorescenceName",c.FluorescenceName),
                                new SqlParameter("@FluorescenceDescription",c.FluorescenceDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateFluorescenceMast", param);
            return "Thankyou! Fluorescence Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateFluorescence";
        }
    }

    /*------------Function For Delete Fluorescence----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteFluorescence(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@FluorescenceId",c.FluorescenceId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteFluorescenceMast", param);
            return "Thankyou! Fluorescence Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteFluorescence";
        }
    }

    /*------------Function For Insert Certification --------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertCertification(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CertificationName",c.CertificationName),
                                new SqlParameter("@CertificationDescription",c.CertificationDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertCertificationMast", param);
            return "Thankyou! Certification Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertCertification";
        }
    }

    /*------------Function For Update Certification---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateCertification(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CertificationId",c.CertificationId),
                                new SqlParameter("@CertificationName",c.CertificationName),
                                new SqlParameter("@CertificationDescription",c.CertificationDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateCertificationMast", param);
            return "Thankyou! Certification Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateCertification";
        }
    }

    /*------------Function For Delete Certification---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteCertification(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CertificationId",c.CertificationId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteCertificationMast", param);
            return "Thankyou! Certification Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteCertification";
        }
    }

    /*------------Function For Insert Inclusion ------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertInclusion(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@InclusionName",c.InclusionName),
                                new SqlParameter("@InclusionDescription",c.InclusionDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertInclusionMast", param);
            return "Thankyou! Inclusion Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertInclusion";
        }
    }

    /*------------Function For Update Inclusion-------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateInclusion(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@InclusionId",c.InclusionId),
                                new SqlParameter("@InclusionName",c.InclusionName),
                                new SqlParameter("@InclusionDescription",c.InclusionDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateInclusionMast", param);
            return "Thankyou! Inclusion Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateInclusion";
        }
    }

    /*------------Function For Delete Inclusion-------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteInclusion(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@InclusionId",c.InclusionId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteInclusionMast", param);
            return "Thankyou! Inclusion Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteInclusion";
        }
    }

    /*------------Function For Insert Lustre ---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertLustre(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@LustreName",c.LustreName),
                                new SqlParameter("@LustreDescription",c.LustreDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertLustreMast", param);
            return "Thankyou! Lustre Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertLustre";
        }
    }

    /*------------Function For Update Lustre----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateLustre(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@LustreId",c.LustreId),
                                new SqlParameter("@LustreName",c.LustreName),
                                new SqlParameter("@LustreDescription",c.LustreDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateLustreMast", param);
            return "Thankyou! Lustre Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateLustre";
        }
    }

    /*------------Function For Delete Lustre----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteLustre(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@LustreId",c.LustreId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteLustreMast", param);
            return "Thankyou! Lustre Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteLustre";
        }
    }

    /*------------Function For Insert Scintillation --------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertScintillation(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ScintillationName",c.ScintillationName),
                                new SqlParameter("@ScintillationDescription",c.ScintillationDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertScintillationMast", param);
            return "Thankyou! Scintillation Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertScintillation";
        }
    }

    /*------------Function For Update Scintillation---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateScintillation(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ScintillationId",c.ScintillationId),
                                new SqlParameter("@ScintillationName",c.ScintillationName),
                                new SqlParameter("@ScintillationDescription",c.ScintillationDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateScintillationMast", param);
            return "Thankyou! Scintillation Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateScintillation";
        }
    }

    /*------------Function For Delete Scintillation---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteScintillation(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ScintillationId",c.ScintillationId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteScintillationMast", param);
            return "Thankyou! Scintillation Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteScintillation";
        }
    }


    /*------------Function For Insert State-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertState(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@StateName",c.StateName),
                                new SqlParameter("@StateDescription",c.StateDescription),
                                new SqlParameter("@CountryId",c.CountryId)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertStateMast", param);
            return "Thankyou! State Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertState";
        }
    }

    /*------------Function For Update State-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateState(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@StateId",c.StateId),
                                new SqlParameter("@StateName",c.StateName),
                                new SqlParameter("@StateDescription",c.StateDescription),
                                new SqlParameter("@CountryId",c.CountryId),
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateStateMast", param);
            return "Thankyou! State Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateState";
        }
    }

    /*------------Function For Delete State-----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteState(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@StateId",c.StateId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteStateMast", param);
            return "Thankyou! State Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteState";
        }
    }

    /*------------Function For Insert City------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertCity(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CityName",c.CityName),
                                new SqlParameter("@CityDescription",c.CityDescription),
                                new SqlParameter("@StateId",c.StateId),
                                new SqlParameter("@CountryId",c.CountryId)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertCityMast", param);
            return "Thankyou! City Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertCity";
        }
    }

    /*------------Function For Update City------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateCity(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CityId",c.CityId),
                                new SqlParameter("@CityName",c.CityName),
                                new SqlParameter("@CityDescription",c.CityDescription),
                                new SqlParameter("@CountryId",c.CountryId),
                                new SqlParameter("@StateId",c.StateId)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateCityMast", param);
            return "Thankyou! City Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateCity";
        }
    }

    /*------------Function For Delete City------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteCity(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@CityId",c.CityId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteCityMast", param);
            return "Thankyou! City Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteCity";
        }
    }
    /*------------Function For Insert Lot ------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertLot(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@LotName",c.LotName),
                                new SqlParameter("@LotDescription",c.LotDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertLotMast", param);
            return "Thankyou! Lot Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertLot";
        }
    }

    /*------------Function For Update Lot-------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateLot(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@LotId",c.LotId),
                                new SqlParameter("@LotName",c.LotName),
                                new SqlParameter("@LotDescription",c.LotDescription)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateLotMast", param);
            return "Thankyou! Lot Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateLot";
        }
    }

    /*------------Function For Delete Lot-------------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteLot(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@LotId",c.LotId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteLotMast", param);
            return "Thankyou! Lot Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteLot";
        }
    }

    /*------------Function For Insert RapRate --------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/

    public static DataTable GetALLByIDRapRate(int RapRateID)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@RapRateID",RapRateID)  };

            DataTable result = DB.ExecuteQueryByProc("SP_GetByIDRapRateMast", param);

            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static DataTable GetRapRate(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ShapeId",c.ShapeId),
                                new SqlParameter("@WeightId",c.WeightId),
                                new SqlParameter("@ColorId",c.ColorId),
                                new SqlParameter("@ClarityId",c.ClarityId)
                               
                                 };

            DataTable result = DB.ExecuteQueryByProc("SP_GetRapRateMast", param);

            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static string ViewAllRapRate()
    {
        DataTable dt = new DataTable();


        dt = DB.ExecuteQueryByProc("SP_GetALLDataRapRateMastVIEW");
        System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        Dictionary<string, object> row;
        foreach (DataRow dr in dt.Rows)
        {
            row = new Dictionary<string, object>();
            foreach (DataColumn col in dt.Columns)
            {
                row.Add(col.ColumnName, dr[col]);
            }
            rows.Add(row);
        }
        return serializer.Serialize(rows);


    }

    public static string ViewDiamondUpdatedPrice()
    {
        DataTable dt = new DataTable();


        dt = DB.ExecuteQueryByProc("SP_SelectDiamondInfoView");
        System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        Dictionary<string, object> row;
        foreach (DataRow dr in dt.Rows)
        {
            row = new Dictionary<string, object>();
            foreach (DataColumn col in dt.Columns)
            {
                row.Add(col.ColumnName, dr[col]);
            }
            rows.Add(row);
        }
        return serializer.Serialize(rows);


    }

    public static string InsertRapRate(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ShapeId",c.ShapeId),
                                new SqlParameter("@WeightId",c.WeightId),
                                new SqlParameter("@ColorId",c.ColorId),
                                new SqlParameter("@ClarityId",c.ClarityId),
                                new SqlParameter("@RapRateName",c.RapRateName)
                                 };

            int result = DB.ExecuteNonQueryByProc("SP_InsertRapRateMast", param);
            return "Thankyou! RapRate Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertRapRate";
        }
    }

    /*------------Function For Update RapRate---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/


    public static string UpdateRapRate(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@RapRateId",Convert.ToInt32(c.RapRateId)),
                                
                                new SqlParameter("@RapRateName",c.RapRateName)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateRapRateMast", param);
            return "Thankyou! RapRate Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateRapRate";
        }
    }

    public static string UpdateTotalPriceByRapRate(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ShapeId",Convert.ToInt32(c.ShapeId)),
                                new SqlParameter("@ColorId",Convert.ToInt32( c.ColorId)),
                                new SqlParameter ("@ClarityId",Convert.ToInt32(c.ClarityId)),
                                new SqlParameter("@WeightID",Convert.ToInt32(c.WeightId)),
                                
                                
                              
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateDiamondPriceByRapRateMast", param);
            return "Thankyou! Diamond Total Price  Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateTotalprice";
        }
    }

    public static void UpdateRapRateFromExclSheet(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ShapeName",c.ShapeName),
                                new SqlParameter("@WeightRange",c.WeightName),
                                new SqlParameter ("@ColorName",c.ColorName),
                                new SqlParameter("@ClarityName",c.ClarityName),
                                 new SqlParameter("@RapRate",c.RapRateName)
                                
                                
                              
                            };

            DB.ExecuteNonQueryByProc("MLCD_RapRateMast_UpdateExclSheetAllData", param);


        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /*------------Function For Delete RapRate---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteRapRate(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@RapRateId",c.RapRateId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteRapRateMast", param);
            return "Thankyou! RapRate Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteRapRate";
        }
    }

    /*------------Function For Insert LooseDiamond ---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertLooseDiamond(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ShapeId",c.ShapeId),
                                new SqlParameter("@ColorId",c.ColorId),
                                new SqlParameter("@ClarityId",c.ClarityId),
                                new SqlParameter("@CutId",c.CutId),
                                new SqlParameter("@SymmetryId",c.SymmetryId),
                                new SqlParameter("@PolishId",c.PolishId),
                                new SqlParameter("@FluorescenceId",c.FluorescenceId),
                                new SqlParameter("@CertificationId",c.CertificationId),
                                new SqlParameter("@InclusionId",c.InclusionId),
                                new SqlParameter("@LustreId",c.LustreId),
                                new SqlParameter("@ScintillationId",c.ScintillationId),
                                new SqlParameter("@CertificationNo",c.CertificationNo),
                                new SqlParameter("@CertificationURL",c.CertificationURL),
                                new SqlParameter("@CertificationImage",c.CertificationImage),
                                new SqlParameter("@DWeight",c.DWeight),
                                new SqlParameter("@DTablePer",c.DTablePer),
                                new SqlParameter("@DDiameter",c.DDiameter),
                                new SqlParameter("@DTotalDepthIn",c.DTotalDepthIn),
                                new SqlParameter("@DTotalDepthPer",c.DTotalDepthPer),
                                new SqlParameter("@DCrownHightIn",c.DCrownHightIn),
                                new SqlParameter("@DCrownHightPer",c.DCrownHightPer),
                                new SqlParameter("@DPavelionDepthIn",c.DPavelionDepthIn),
                                new SqlParameter("@DPavelionDepthPer",c.DPavelionDepthPer),
                                new SqlParameter("@DGridleThickness",c.DGridleThickness),
                                new SqlParameter("@DCulet",c.DCulet),
                                new SqlParameter("@DDiscount",c.DDiscount),
                                new SqlParameter("@DSellingPrice",c.DSellingPrice),
                                new SqlParameter("@DDiscription",c.DDiscription),
                                new SqlParameter("@DiamondImage1",c.DiamondImage1),
                                new SqlParameter("@DiamondImage2",c.DiamondImage2) ,
                                new SqlParameter("@DiamondStatus",c.DiamondStatus),
                                new SqlParameter("@MembersDiscount",c.MembersDiscount),
                                new SqlParameter("@IsMember",c.Membertype),
                                new SqlParameter("@DiamondType",c.DiamondType),
                                new SqlParameter("@DCps",c.cps)
                                 };

            int result = DB.ExecuteNonQueryByProc("SP_InsertLooseDiamond", param);
            return "Thankyou! LooseDiamond Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertLooseDiamond" + ex.Message;
        }
    }

    public static string AddRemarkLooseDiamond(Common c)
    {
        try
        {
            SqlParameter[] param ={
                            
                               
                                new SqlParameter("@DID",Convert.ToInt32(c.DID)),
                                new SqlParameter("@Remark",c.Remark)
                                                            
                                 };

            int result = DB.ExecuteNonQueryByProc("MLCD_LooseDiamond_AddRemarks", param);
            return "Thankyou! Added Remark Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertLooseDiamond" + ex.Message;
        }
    }

    /*------------Function For Update LooseDiamond----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateLooseDiamond(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@DID",c.DID),
                                new SqlParameter("@ShapeId",c.ShapeId),
                                new SqlParameter("@ColorId",c.ColorId),
                                new SqlParameter("@ClarityId",c.ClarityId),
                                new SqlParameter("@CutId",c.CutId),
                                new SqlParameter("@SymmetryId",c.SymmetryId),
                                new SqlParameter("@PolishId",c.PolishId),
                                new SqlParameter("@FluorescenceId",c.FluorescenceId),
                                new SqlParameter("@CertificationId",c.CertificationId),
                                new SqlParameter("@InclusionId",c.InclusionId),
                                new SqlParameter("@LustreId",c.LustreId),
                                new SqlParameter("@ScintillationId",c.ScintillationId),
                                new SqlParameter("@CertificationNo",c.CertificationNo),
                                new SqlParameter("@CertificationURL",c.CertificationURL),
                                new SqlParameter("@CertificationImage",c.CertificationImage),
                                new SqlParameter("@DWeight",c.DWeight),
                                new SqlParameter("@DTablePer",c.DTablePer),
                                new SqlParameter("@DDiameter",c.DDiameter),
                                new SqlParameter("@DTotalDepthIn",c.DTotalDepthIn),
                                new SqlParameter("@DTotalDepthPer",c.DTotalDepthPer),
                                new SqlParameter("@DCrownHightIn",c.DCrownHightIn),
                                new SqlParameter("@DCrownHightPer",c.DCrownHightPer),
                                new SqlParameter("@DPavelionDepthIn",c.DPavelionDepthIn),
                                new SqlParameter("@DPavelionDepthPer",c.DPavelionDepthPer),
                                new SqlParameter("@DGridleThickness",c.DGridleThickness),
                                new SqlParameter("@DCulet",c.DCulet),
                                new SqlParameter("@DDiscount",c.DDiscount),
                                new SqlParameter("@DSellingPrice",c.DSellingPrice),
                                new SqlParameter("@DDiscription",c.DDiscription),
                                new SqlParameter("@DiamondImage1",c.DiamondImage1),
                                new SqlParameter("@DiamondImage2",c.DiamondImage2) ,
                                new SqlParameter("@DiamondStatus",c.DiamondStatus),
                                new SqlParameter("@MembersDiscount",c.MembersDiscount),
                                new SqlParameter("@IsMember",c.Membertype),
                                new SqlParameter("@DCps",c.cps)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateLooseDiamond", param);
            return "Thankyou! LooseDiamond Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateLooseDiamond";
        }
    }

    /*------------Function For Delete LooseDiamond----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteLooseDiamond(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@DID",c.DID)                               
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteLooseDiamond", param);
            return "Thankyou! LooseDiamond Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteLooseDiamond";
        }
    }

    /*------------Function For Enable LooseDiamond----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string EnableLooseDiamond(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@DID",c.DID)                               
                            };

            int result = DB.ExecuteNonQueryByProc("SP_EnableLooseDiamond", param);
            return "Thankyou! LooseDiamond Enable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:EnableLooseDiamond";
        }
    }

    /*------------Function For Insert ClubMember ---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertClubMember(Common c)
    {
        try
        {
            SqlParameter[] param ={
                              
                                new SqlParameter("@CName",c.CName),
                                new SqlParameter("@PName",c.PName),
                                new SqlParameter("@CAddress",c.CAddress),
                                new SqlParameter("@RegistrationNo",c.RegistrationNo),
                                new SqlParameter("@RegNo",c.RegNo),
                                new SqlParameter("@PanCardNo",c.PanCardNo),  
                                new SqlParameter("@PanNo",c.PanNo),  
                                new SqlParameter("@EmailId",c.EmailId),
                                new SqlParameter("@MobileNo",c.MobileNo)
                                                                          
                                 };

            int result = DB.ExecuteNonQueryByProc("SP_InsertClubMemberInfo", param);
            return "Thankyou! Club Member Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertClubMember";
        }
    }


    /*------------Function For Delete ClubMember----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static DataTable DeleteClubMember(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@MID",c.MID)                               
                            };

            DataTable dt = DB.ExecuteQueryByProc("SP_DeleteClubMemberInfo", param);
            return dt;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /*------------Function For Insert Diamond Pair----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertDiamondPair(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@PFrom",c.PFrom),
                                new SqlParameter("@PTo",c.PTo),
                                new SqlParameter("@Dstatus",c.DiamondStatus)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertPairDiamond", param);
            return "Thankyou! Diamond Pair Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertDiamondPair";
        }
    }

    /*------------Function For Insert Diamond Near Pair-----------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertDiamondNearPair(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@NPFrom",c.NPFrom),
                                new SqlParameter("@NPTo",c.NPTo)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertNearPairDiamond", param);
            return "Thankyou! Diamond Near Pair Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertDiamondNearPair";
        }
    }

    /*------------Function For Insert ASearch --------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertASearch(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@ASName",c.ASName),
                                new SqlParameter("@ASContact",c.ASContact),
                                new SqlParameter("@ASEmail",c.ASEmail),
                                new SqlParameter("@AComment",c.AComment),
                                new SqlParameter("@ASearch",c.ASearch)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertASearchInfo", param);
            return "Thankyou! ASearch Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertASearch";
        }
    }

    /*------------Function For Insert LotNumber ------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertLotNumber(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@DID",c.DID),
                                new SqlParameter("@LotId",c.LotId),
                                new SqlParameter("@OwnerName",c.OwnerName),
                                new SqlParameter("@OwnerAddress",c.OwnerAddress),
                                new SqlParameter("@ReceivedPlace",c.ReceivedPlace),
                                new SqlParameter("@ReceivedPerson",c.ReceivedPerson),
                                new SqlParameter("@LotRemark",c.LotRemark)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertLotNumberInfo", param);
            return "Thankyou! LotNumber Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertLotNumber";
        }
    }

    /*------------Function For Update LotNumber-------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateLotNumber(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@LotNumberId",c.LotNumberId),
                                new SqlParameter("@DID",c.DID),
                                new SqlParameter("@LotId",c.LotId),
                                new SqlParameter("@OwnerName",c.OwnerName),
                                new SqlParameter("@OwnerAddress",c.OwnerAddress),
                                new SqlParameter("@ReceivedPlace",c.ReceivedPlace),
                                new SqlParameter("@ReceivedPerson",c.ReceivedPerson),
                                new SqlParameter("@LotRemark",c.LotRemark)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateLotNumberInfo", param);
            return "Thankyou! LotNumber Update Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateLotNumber";
        }
    }

    /*------------Function For Delete LotNumber-------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeleteLotNumber(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@LotNumberId",c.LotNumberId)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeleteLotNumberInfo", param);
            return "Thankyou! LotNumber Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteLotNumber";
        }
    }

    /*------------Function For Insert Country --------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string InsertPDiamondRequest(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@PDName",c.PDName),
                                new SqlParameter("@PContact",c.PContact),
                                new SqlParameter("@PEmail",c.PEmail),
                                new SqlParameter("@PShape",c.PShape),
                                new SqlParameter("@PWeight",c.PWeight),
                                new SqlParameter("@PColor",c.PColor),
                                new SqlParameter("@PClarity",c.PClarity),
                                new SqlParameter("@PComment",c.PComment)
                            };

            int result = DB.ExecuteNonQueryByProc("SP_InsertPDiamondRequest", param);
            return "Thankyou! Request Save Successfully";

        }
        catch (Exception ex)
        {
            return "EC:InsertPDiamondRequest";
        }
    }

    public static string DRemark(int DID)
    {
        try
        {
            SqlParameter[] pram = { new SqlParameter("@DID", DID) };
            string str = DB.ExecuteScaler("SP_MLCD_LooseDiamond_selectRemark", pram);

            return str;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
    public static DataTable GetViewDiamond(int DID)
    {
        try
        {
            SqlParameter[] pram = { new SqlParameter("@DID", DID) };
            DataTable dt = DB.ExecuteQueryByProc("MLCD_LooseDiamond_ViewDiamons", pram);

            return dt;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
    public static DataTable GetViewDisabledDiamond(int DID, int Disval)
    {
        try
        {
            SqlParameter[] pram = { new SqlParameter("@DID", DID), new SqlParameter("@Isactive", Disval) };
            DataTable dt = DB.ExecuteQueryByProc("MLCD_LooseDiamond_ViewDisabledDiamons", pram);

            return dt;
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
    /*------------Function For Delete Country---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string DeletePDiamondRequest(Common c)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@PDRID",c.PDRID)                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_DeletePDiamondRequest", param);
            return "Thankyou! Request Disable Successfully";

        }
        catch (Exception ex)
        {
            return "EC:DeleteCountry";
        }
    }

    /*------------Function For Fatch Diamond Price ---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string GetDiamondPrice(string DID)
    {
        string Price = DB.FatchColumnNameString("MLCD_LooseDiamond", "DID", DID, "Price");
        if (Price != "")
        {
            return Price;
        }
        else
        {
            return "0.00";
        }
    }

    public static string GetDiamondPricemember(string DID)
    {
        string Price = DB.FatchColumnNameString("MLCD_LooseDiamond", "DID", DID, "membermlprice");
        if (Price != "")
        {
            return Price;
        }
        else
        {
            return "0.00";
        }
    }

    /*------------Function For Fatch SQL String ------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string FatchSqlDiamondInfo()
    {
        return "SELECT LO.DID,SH.ShapeId, SH.ShapeName,CO.ColorId, CO.ColorName,CL.ClarityId, CL.ClarityName,CU.CutId, CU.CutName,SY.SymmetryId, SY.SymmetryName,PO.PolishId, PO.PolishName,FL.FluorescenceId, FL.FluorescenceName,CE.CertificationId, CE.CertificationName,IC.InclusionId, IC.InclusionName,LU.LustreId, LU.LustreName,SC.ScintillationId, SC.ScintillationName,LO.CertificationNo,LO.CertificationURL,LO.CertificationImage,LO.DWeight,LO.DTablePer,LO.DDiameter,LO.DTotalDepthIn,LO.DTotalDepthPer,LO.DCrownHightIn,LO.DCrownHightPer,LO.DCps,LO.DPavelionDepthIn,LO.DPavelionDepthPer,LO.DGridleThickness,LO.DCulet,LO.DDiscount,LO.DSellingPrice,LO.DDiscription,LO.DiamondImage1,LO.DiamondImage2,LO.Price, LO.DiamondStatus, LO.Currentdate,LO.DPriceWRap,LO.DiamondType FROM MLCD_ShapeMast SH,MLCD_ColorMast CO,MLCD_ClarityMast CL,MLCD_CutMast CU,MLCD_SymmetryMast SY,MLCD_PolishMast PO,MLCD_FluorescenceMast FL,MLCD_CertificationMast CE,MLCD_InclusionMast IC,MLCD_LustreMast LU,MLCD_ScintillationMast SC, MLCD_LooseDiamond LO WHERE LO.ShapeId=SH.ShapeId AND LO.ColorId=CO.ColorId AND LO.ClarityId=CL.ClarityId AND LO.CutId=CU.CutId AND LO.SymmetryId=SY.SymmetryId AND LO.PolishId=PO.PolishId AND LO.FluorescenceId=FL.FluorescenceId AND LO.CertificationId=CE.CertificationId AND LO.InclusionId=IC.InclusionId AND LO.LustreId=LU.LustreId AND LO.ScintillationId=SC.ScintillationId AND IsUserMember IN ('U','UM')  AND LO.IsActive=1";
    }

    public static string FatchSqlDiamondInfomember()
    {
        return "SELECT LO.DID,SH.ShapeId, SH.ShapeName,CO.ColorId, CO.ColorName,CL.ClarityId, CL.ClarityName,CU.CutId, CU.CutName,SY.SymmetryId, SY.SymmetryName,PO.PolishId, PO.PolishName,FL.FluorescenceId, FL.FluorescenceName,CE.CertificationId, CE.CertificationName,IC.InclusionId, IC.InclusionName,LU.LustreId, LU.LustreName,SC.ScintillationId, SC.ScintillationName,LO.CertificationNo,LO.CertificationURL,LO.DCps, LO.CertificationImage,LO.membermlprice,LO.membersdiscount ,LO.DWeight,LO.DTablePer,LO.DDiameter,LO.DTotalDepthIn,LO.DTotalDepthPer,LO.DCrownHightIn,LO.DCrownHightPer,LO.DPavelionDepthIn,LO.DPavelionDepthPer,LO.DGridleThickness,LO.DCulet,LO.DDiscount,LO.DSellingPrice,LO.DDiscription,LO.DiamondImage1,LO.DiamondImage2,LO.Price, LO.DiamondStatus, LO.Currentdate,LO.DPriceWRap,LO.DiamondType FROM MLCD_ShapeMast SH,MLCD_ColorMast CO,MLCD_ClarityMast CL,MLCD_CutMast CU,MLCD_SymmetryMast SY,MLCD_PolishMast PO,MLCD_FluorescenceMast FL,MLCD_CertificationMast CE,MLCD_InclusionMast IC,MLCD_LustreMast LU,MLCD_ScintillationMast SC, MLCD_LooseDiamond LO WHERE LO.ShapeId=SH.ShapeId AND LO.ColorId=CO.ColorId AND LO.ClarityId=CL.ClarityId AND LO.CutId=CU.CutId AND LO.SymmetryId=SY.SymmetryId AND LO.PolishId=PO.PolishId AND LO.FluorescenceId=FL.FluorescenceId AND LO.CertificationId=CE.CertificationId AND LO.InclusionId=IC.InclusionId AND LO.LustreId=LU.LustreId AND LO.ScintillationId=SC.ScintillationId AND IsUserMember IN ('M','UM') AND LO.IsActive=1";
    }

    /*------------Function For Fatch SQL String ------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string FatchSqlDisableDiamond()
    {
        return "SELECT LO.DID,LO.ItemDisableDate,SH.ShapeId, SH.ShapeName,CO.ColorId, CO.ColorName,CL.ClarityId, CL.ClarityName,CU.CutId, CU.CutName,SY.SymmetryId, SY.SymmetryName,PO.PolishId, PO.PolishName,FL.FluorescenceId, FL.FluorescenceName,CE.CertificationId, CE.CertificationName,IC.InclusionId, IC.InclusionName,LU.LustreId, LU.LustreName,SC.ScintillationId, SC.ScintillationName,LO.CertificationNo,LO.CertificationURL,LO.CertificationImage,LO.DWeight,LO.DTablePer,LO.DDiameter,LO.DTotalDepthIn,LO.DTotalDepthPer,LO.DCrownHightIn,LO.DCrownHightPer,LO.DPavelionDepthIn,LO.DPavelionDepthPer,LO.DGridleThickness,LO.DCulet,LO.DDiscount,LO.DSellingPrice,LO.DDiscription,LO.DiamondImage1,LO.DiamondImage2,LO.Price, LO.DiamondStatus FROM MLCD_ShapeMast SH,MLCD_ColorMast CO,MLCD_ClarityMast CL,MLCD_CutMast CU,MLCD_SymmetryMast SY,MLCD_PolishMast PO,MLCD_FluorescenceMast FL,MLCD_CertificationMast CE,MLCD_InclusionMast IC,MLCD_LustreMast LU,MLCD_ScintillationMast SC, MLCD_LooseDiamond LO WHERE LO.ShapeId=SH.ShapeId AND LO.ColorId=CO.ColorId AND LO.ClarityId=CL.ClarityId AND LO.CutId=CU.CutId AND LO.SymmetryId=SY.SymmetryId AND LO.PolishId=PO.PolishId AND LO.FluorescenceId=FL.FluorescenceId AND LO.CertificationId=CE.CertificationId AND LO.InclusionId=IC.InclusionId AND LO.LustreId=LU.LustreId AND LO.ScintillationId=SC.ScintillationId AND LO.IsActive=0";
    }

    /*------------Function For Fatch SQL String1 -----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string FatchSqlDisableDiamond(string DID)
    {
        return "SELECT LO.DID,SH.ShapeId, SH.ShapeName,CO.ColorId, CO.ColorName,CL.ClarityId, CL.ClarityName,CU.CutId, CU.CutName,SY.SymmetryId, SY.SymmetryName,PO.PolishId, PO.PolishName,FL.FluorescenceId, FL.FluorescenceName,CE.CertificationId, CE.CertificationName,IC.InclusionId, IC.InclusionName,LU.LustreId, LU.LustreName,SC.ScintillationId, SC.ScintillationName,LO.CertificationNo,LO.CertificationURL,LO.CertificationImage,LO.DWeight,LO.DTablePer,LO.DDiameter,LO.DTotalDepthIn,LO.DTotalDepthPer,LO.DCrownHightIn,LO.DCrownHightPer,LO.DPavelionDepthIn,LO.DPavelionDepthPer,LO.DGridleThickness,LO.DCulet,LO.DDiscount,LO.DSellingPrice,LO.DDiscription,LO.DiamondImage1,LO.DiamondImage2,LO.Price, LO.DiamondStatus FROM MLCD_ShapeMast SH,MLCD_ColorMast CO,MLCD_ClarityMast CL,MLCD_CutMast CU,MLCD_SymmetryMast SY,MLCD_PolishMast PO,MLCD_FluorescenceMast FL,MLCD_CertificationMast CE,MLCD_InclusionMast IC,MLCD_LustreMast LU,MLCD_ScintillationMast SC, MLCD_LooseDiamond LO WHERE LO.ShapeId=SH.ShapeId AND LO.ColorId=CO.ColorId AND LO.ClarityId=CL.ClarityId AND LO.CutId=CU.CutId AND LO.SymmetryId=SY.SymmetryId AND LO.PolishId=PO.PolishId AND LO.FluorescenceId=FL.FluorescenceId AND LO.CertificationId=CE.CertificationId AND LO.InclusionId=IC.InclusionId AND LO.LustreId=LU.LustreId AND LO.ScintillationId=SC.ScintillationId AND LO.IsActive=0 AND LO.DID=" + DID;
    }

    /*------------Function For Fatch SQL String1 -----------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string FatchSqlDiamondInfo(string DID)
    {
        return "SELECT LO.DID,SH.ShapeId, SH.ShapeName,CO.ColorId, CO.ColorName,CL.ClarityId, CL.ClarityName,CU.CutId, CU.CutName,SY.SymmetryId, SY.SymmetryName,PO.PolishId, PO.PolishName,FL.FluorescenceId, FL.FluorescenceName,CE.CertificationId, CE.CertificationName,IC.InclusionId, IC.InclusionName,LU.LustreId, LU.LustreName,SC.ScintillationId, SC.ScintillationName,LO.CertificationNo,LO.CertificationURL,LO.CertificationImage,LO.MemberMLPrice,LO.DWeight,LO.DTablePer,LO.DDiameter,LO.DTotalDepthIn,LO.DTotalDepthPer,LO.DCrownHightIn,LO.DCrownHightPer,LO.DPavelionDepthIn,LO.DPavelionDepthPer,LO.DGridleThickness,LO.DCulet,LO.DDiscount,LO.DSellingPrice,LO.DDiscription,LO.DiamondImage1,LO.DiamondImage2,LO.Price, LO.DiamondStatus, LO.DHoldRemark FROM MLCD_ShapeMast SH,MLCD_ColorMast CO,MLCD_ClarityMast CL,MLCD_CutMast CU,MLCD_SymmetryMast SY,MLCD_PolishMast PO,MLCD_FluorescenceMast FL,MLCD_CertificationMast CE,MLCD_InclusionMast IC,MLCD_LustreMast LU,MLCD_ScintillationMast SC, MLCD_LooseDiamond LO WHERE LO.ShapeId=SH.ShapeId AND LO.ColorId=CO.ColorId AND LO.ClarityId=CL.ClarityId AND LO.CutId=CU.CutId AND LO.SymmetryId=SY.SymmetryId AND LO.PolishId=PO.PolishId AND LO.FluorescenceId=FL.FluorescenceId AND LO.CertificationId=CE.CertificationId AND LO.InclusionId=IC.InclusionId AND LO.LustreId=LU.LustreId AND LO.ScintillationId=SC.ScintillationId AND LO.IsActive=1 AND LO.DID=" + DID;
    }


    /*------------Function For Update UpdateUnpair ---------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateUnpair(string DID1, string DID2)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@DID1",DID1),
                                new SqlParameter("@DID2",DID2)
                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateUnpair", param);
            return "Thankyou! Pair Update into Unpair Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateUnpair";
        }
    }

    /*------------Function For Update UpdateNUnpair --------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateNUnpair(string DID1, string DID2)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@DID1",DID1),
                                new SqlParameter("@DID2",DID2)
                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateNUnpair", param);
            return "Thankyou! Pair Update into Unpair Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateNUnpair";
        }
    }

    /*------------Function For Update Hold -----------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateDiamondHold(string DID, string HRemark)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@DID",Convert.ToInt32(DID)),
                                 new SqlParameter("@HoldRemark",HRemark)
                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateDiamondHold", param);
            return "Thankyou! Diamond Hold Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateDiamondHold";
        }
    }
    /*------------Function For Update UnHold ---------------------------------------------------------*/
    /*------------------------------------------------------------------------------------------------*/
    public static string UpdateDiamondUnHold(string DID)
    {
        try
        {
            SqlParameter[] param ={
                                new SqlParameter("@DID",DID)
                                
                            };

            int result = DB.ExecuteNonQueryByProc("SP_UpdateDiamondUnHold", param);
            return "Thankyou! Diamond UnHold Successfully";

        }
        catch (Exception ex)
        {
            return "EC:UpdateDiamondUnHold";
        }
    }



    /*------------Function for member-------------------*/
    /*--------------------------------------------------------*/
    public static bool memberLogin(Common c)
    {
        try
        {

            SqlParameter[] pram ={new SqlParameter("@EmailID",c.EmailID),
                                new SqlParameter("@MemberPassword",c.MemberPassword)};

            int val = (int)DB.ExecuteScalervalue("SP_MLCD_ClubMemberInfo_Login", pram);
            return val == 1;

        }

        catch
        {

            return false;
        }




    }


    // new methods [SP_SelectDiamondInfoByCertNO]
    public static DataTable getFilterDiamond(string fromdat, string todate)
    {



        SqlParameter[] pram = { new SqlParameter("@dateFrom", fromdat), new SqlParameter("@dateto", todate) };
        DataTable dt = DB.ExecuteQueryByProc("SP_SelectDiamondInfoByDate", pram);
        return dt;

    }
    public static DataTable getFilterDiamond(string ceritno)
    {



        SqlParameter[] pram = { new SqlParameter("@Certitno", ceritno) };
        DataTable dt = DB.ExecuteQueryByProc("SP_SelectDiamondInfoByCertNO", pram);
        return dt;

    }

    //Disable products
    public static DataTable getFilterDiamondDisable(string fromdat, string todate)
    {



        SqlParameter[] pram = { new SqlParameter("@dateFrom", fromdat), new SqlParameter("@dateto", todate) };
        DataTable dt = DB.ExecuteQueryByProc("SP_SelectDiamondInfoByDateDisable", pram);
        return dt;

    }
    public static DataTable getFilterDiamondDisable(string ceritno) 
    {



        SqlParameter[] pram = { new SqlParameter("@Certitno", ceritno) };
        DataTable dt = DB.ExecuteQueryByProc("SP_SelectDiamondInfoByCertNODisable", pram);
        return dt;

    }
}