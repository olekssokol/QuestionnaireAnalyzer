﻿namespace QuestionnaireAnalyzer.Contracts.Models.Dir;

public class DirFeasibilityModel
{
    public int Id { get; set; }
    public DateOnly Data { get; set; } //TODO: need implement

    #region ID
    public int ID_AM_1 { get; set; }
    public int ID_AM_2 { get; set; }
    public int ID_AM_3 { get; set; }
    public int ID_AM_4 { get; set; }
    public int ID_AM_5 { get; set; }
    public int ID_AM_6 { get; set; }


    public int ID_BE_1 { get; set; }
    public int ID_BE_2 { get; set; }
    public int ID_BE_3 { get; set; }
    public int ID_BE_4 { get; set; }
    public int ID_BE_5 { get; set; }


    public int ID_GV_1 { get; set; }
    public int ID_GV_2 { get; set; }
    public int ID_GV_3 { get; set; }
    public int ID_GV_4 { get; set; }


    public int ID_RA_1 { get; set; }
    public int ID_RA_2 { get; set; }
    public int ID_RA_3 { get; set; }
    public int ID_RA_4 { get; set; }
    public int ID_RA_5 { get; set; }
    public int ID_RA_6 { get; set; }


    public int ID_RM_1 { get; set; }
    public int ID_RM_2 { get; set; }
    public int ID_RM_3 { get; set; }


    public int ID_SC_1 { get; set; }
    public int ID_SC_2 { get; set; }
    public int ID_SC_3 { get; set; }
    public int ID_SC_4 { get; set; }
    public int ID_SC_5 { get; set; }

    #endregion

    #region PR
    public int PR_AC_1 { get; set; }
    public int PR_AC_2 { get; set; }
    public int PR_AC_3 { get; set; }
    public int PR_AC_4 { get; set; }
    public int PR_AC_5 { get; set; }
    public int PR_AC_6 { get; set; }
    public int PR_AC_7 { get; set; }


    public int PR_AT_1 { get; set; }
    public int PR_AT_2 { get; set; }
    public int PR_AT_3 { get; set; }
    public int PR_AT_4 { get; set; }
    public int PR_AT_5 { get; set; }


    public int PR_DS_1 { get; set; }
    public int PR_DS_2 { get; set; }
    public int PR_DS_3 { get; set; }
    public int PR_DS_4 { get; set; }
    public int PR_DS_5 { get; set; }
    public int PR_DS_6 { get; set; }
    public int PR_DS_7 { get; set; }
    public int PR_DS_8 { get; set; }


    public int PR_IP_1 { get; set; }
    public int PR_IP_2 { get; set; }
    public int PR_IP_3 { get; set; }
    public int PR_IP_4 { get; set; }
    public int PR_IP_5 { get; set; }
    public int PR_IP_6 { get; set; }
    public int PR_IP_7 { get; set; }
    public int PR_IP_8 { get; set; }
    public int PR_IP_9 { get; set; }
    public int PR_IP_10 { get; set; }
    public int PR_IP_11 { get; set; }
    public int PR_IP_12 { get; set; }


    public int PR_MA_1 { get; set; }
    public int PR_MA_2 { get; set; }

    public int PR_RT_1 { get; set; }
    public int PR_RT_2 { get; set; }
    public int PR_RT_3 { get; set; }
    public int PR_RT_4 { get; set; }
    public int PR_RT_5 { get; set; }

    #endregion

    #region DE
    public int DE_AE_1 { get; set; }
    public int DE_AE_2 { get; set; }
    public int DE_AE_3 { get; set; }
    public int DE_AE_4 { get; set; }
    public int DE_AE_5 { get; set; }


    public int DE_CM_1 { get; set; }
    public int DE_CM_2 { get; set; }
    public int DE_CM_3 { get; set; }
    public int DE_CM_4 { get; set; }
    public int DE_CM_5 { get; set; }
    public int DE_CM_6 { get; set; }
    public int DE_CM_7 { get; set; }
    public int DE_CM_8 { get; set; }


    public int DE_DP_1 { get; set; }
    public int DE_DP_2 { get; set; }
    public int DE_DP_3 { get; set; }
    public int DE_DP_4 { get; set; }
    public int DE_DP_5 { get; set; }

    #endregion

    #region RS

    public int RS_RP_1 { get; set; }


    public int RS_CO_1 { get; set; }
    public int RS_CO_2 { get; set; }
    public int RS_CO_3 { get; set; }
    public int RS_CO_4 { get; set; }
    public int RS_CO_5 { get; set; }


    public int RS_AN_1 { get; set; }
    public int RS_AN_2 { get; set; }
    public int RS_AN_3 { get; set; }
    public int RS_AN_4 { get; set; }
    public int RS_AN_5 { get; set; }


    public int RS_MI_1 { get; set; }
    public int RS_MI_2 { get; set; }
    public int RS_MI_3 { get; set; }


    public int RS_IM_1 { get; set; }
    public int RS_IM_2 { get; set; }

    #endregion


    #region RC

    public int RC_RP_1 { get; set; }


    public int RC_IM_1 { get; set; }
    public int RC_IM_2 { get; set; }


    public int RC_CO_1 { get;}
    public int RC_CO_2 { get; set; }
    public int RC_CO_3 { get; set; }

    #endregion

    #region ID
    public string ID_AM_1_text { get; set; }
    public string ID_AM_2_text { get; set; }
    public string ID_AM_3_text { get; set; }
    public string ID_AM_4_text { get; set; }
    public string ID_AM_5_text { get; set; }
    public string ID_AM_6_text { get; set; }


    public string ID_BE_1_text { get; set; }
    public string ID_BE_2_text { get; set; }
    public string ID_BE_3_text { get; set; }
    public string ID_BE_4_text { get; set; }
    public string ID_BE_5_text { get; set; }


    public string ID_GV_1_text { get; set; }
    public string ID_GV_2_text { get; set; }
    public string ID_GV_3_text { get; set; }
    public string ID_GV_4_text { get; set; }


    public string ID_RA_1_text { get; set; }
    public string ID_RA_2_text { get; set; }
    public string ID_RA_3_text { get; set; }
    public string ID_RA_4_text { get; set; }
    public string ID_RA_5_text { get; set; }
    public string ID_RA_6_text { get; set; }


    public string ID_RM_1_text { get; set; }
    public string ID_RM_2_text { get; set; }
    public string ID_RM_3_text { get; set; }


    public string ID_SC_1_text { get; set; }
    public string ID_SC_2_text { get; set; }
    public string ID_SC_3_text { get; set; }
    public string ID_SC_4_text { get; set; }
    public string ID_SC_5_text { get; set; }

    #endregion

    #region PR
    public string PR_AC_1_text { get; set; }
    public string PR_AC_2_text { get; set; }
    public string PR_AC_3_text { get; set; }
    public string PR_AC_4_text { get; set; }
    public string PR_AC_5_text { get; set; }
    public string PR_AC_6_text { get; set; }
    public string PR_AC_7_text { get; set; }


    public string PR_AT_1_text { get; set; }
    public string PR_AT_2_text { get; set; }
    public string PR_AT_3_text { get; set; }
    public string PR_AT_4_text { get; set; }
    public string PR_AT_5_text { get; set; }


    public string PR_DS_1_text { get; set; }
    public string PR_DS_2_text { get; set; }
    public string PR_DS_3_text { get; set; }
    public string PR_DS_4_text { get; set; }
    public string PR_DS_5_text { get; set; }
    public string PR_DS_6_text { get; set; }
    public string PR_DS_7_text { get; set; }
    public string PR_DS_8_text { get; set; }


    public string PR_IP_1_text { get; set; }
    public string PR_IP_2_text { get; set; }
    public string PR_IP_3_text { get; set; }
    public string PR_IP_4_text { get; set; }
    public string PR_IP_5_text { get; set; }
    public string PR_IP_6_text { get; set; }
    public string PR_IP_7_text { get; set; }
    public string PR_IP_8_text { get; set; }
    public string PR_IP_9_text { get; set; }
    public string PR_IP_10_text { get; set; }
    public string PR_IP_11_text { get; set; }
    public string PR_IP_12_text { get; set; }


    public string PR_MA_1_text { get; set; }
    public string PR_MA_2_text { get; set; }

    public string PR_RT_1_text { get; set; }
    public string PR_RT_2_text { get; set; }
    public string PR_RT_3_text { get; set; }
    public string PR_RT_4_text { get; set; }
    public string PR_RT_5_text { get; set; }

    #endregion

    #region DE
    public string DE_AE_1_text { get; set; }
    public string DE_AE_2_text { get; set; }
    public string DE_AE_3_text { get; set; }
    public string DE_AE_4_text { get; set; }
    public string DE_AE_5_text { get; set; }


    public string DE_CM_1_text { get; set; }
    public string DE_CM_2_text { get; set; }
    public string DE_CM_3_text { get; set; }
    public string DE_CM_4_text { get; set; }
    public string DE_CM_5_text { get; set; }
    public string DE_CM_6_text { get; set; }
    public string DE_CM_7_text { get; set; }
    public string DE_CM_8_text { get; set; }


    public string DE_DP_1_text { get; set; }
    public string DE_DP_2_text { get; set; }
    public string DE_DP_3_text { get; set; }
    public string DE_DP_4_text { get; set; }
    public string DE_DP_5_text { get; set; }

    #endregion

    #region RS

    public string RS_RP_1_text { get; set; }


    public string RS_CO_1_text { get; set; }
    public string RS_CO_2_text { get; set; }
    public string RS_CO_3_text { get; set; }
    public string RS_CO_4_text { get; set; }
    public string RS_CO_5_text { get; set; }


    public string RS_AN_1_text { get; set; }
    public string RS_AN_2_text { get; set; }
    public string RS_AN_3_text { get; set; }
    public string RS_AN_4_text { get; set; }
    public string RS_AN_5_text { get; set; }


    public string RS_MI_1_text { get; set; }
    public string RS_MI_2_text { get; set; }
    public string RS_MI_3_text { get; set; }


    public string RS_IM_1_text { get; set; }
    public string RS_IM_2_text { get; set; }

    #endregion


    #region RC

    public string RC_RP_1_text { get; set; }


    public string RC_IM_1_text { get; set; }
    public string RC_IM_2_text { get; set; }


    public string RC_CO_1_text { get; }
    public string RC_CO_2_text { get; set; }
    public string RC_CO_3_text { get; set; }

    #endregion

}