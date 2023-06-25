﻿namespace BackEnd_API.Const
{
    public static class ApiRouteV1
    {
        #region Address
        public const string Address_GetAll = "v1/address/getall";
        public const string Address_Get = "v1/address/get";
        public const string Address_Add = "v1/address/add";
        public const string Address_Update = "v1/address/update";
        public const string Address_Delete = "v1/address/delete";
        public const string Address_ChangeStatus = "v1/address/changestatus";
        #endregion

        #region AboutUs
        public const string AboutUs_GetAll = "v1/aboutus/getall";
        public const string AboutUs_Get = "v1/aboutus/get";
        public const string AboutUs_Add = "v1/aboutus/add";
        public const string AboutUs_Update = "v1/aboutus/update";
        public const string AboutUs_Delete = "v1/aboutus/delete";
        public const string AboutUs_ChangeStatus = "v1/aboutus/changestatus";
        #endregion

        #region Banner
        public const string Banner_GetAll = "v1/banner/getall";
        public const string Banner_GetFilter = "v1/banner/filter-banner";
        public const string Banner_Get = "v1/banner/get";
        public const string Banner_Add = "v1/banner/add";
        public const string Banner_Update = "v1/banner/update";
        public const string Banner_Delete = "v1/banner/delete";
        public const string Banner_ChangeStatus = "v1/banner/changestatus";
        #endregion

        #region BlogContent
        public const string BlogContent_GetAll = "v1/blogcontent/getall";
        public const string BlogContent_GetAll_WithDetails = "v1/blogcontent/getall/withdetails";
        public const string BlogContent_Get = "v1/blogcontent/get";
        public const string BlogContent_Get_WithDetails = "v1/blogcontent/get/withdetails";
        public const string BlogContent_Get_Filter = "v1/blogcontent/filter-blogcontents";
        public const string BlogContent_Add = "v1/blogcontent/add";
        public const string BlogContent_Update = "v1/blogcontent/update";
        public const string BlogContent_Delete = "v1/blogcontent/delete";
        public const string BlogContent_ChangeStatus = "v1/blogcontent/changestatus";
        #endregion

        #region BlogGroup
        public const string BlogGroup_GetAll = "v1/bloggroup/getall";
        public const string BlogGroup_Get = "v1/bloggroup/get";
        public const string BlogGroup_Add = "v1/bloggroup/add";
        public const string BlogGroup_Update = "v1/bloggroup/update";
        public const string BlogGroup_Delete = "v1/bloggroup/delete";
        public const string BlogGroup_ChangeStatus = "v1/bloggroup/changestatus";
        #endregion

        #region CommonQuestiom
        public const string CommonQuestiom_GetAll = "v1/commonquestiom/getall";
        public const string CommonQuestiom_Get = "v1/commonquestiom/get";
        public const string CommonQuestiom_Add = "v1/commonquestiom/add";
        public const string CommonQuestiom_Update = "v1/commonquestiom/update";
        public const string CommonQuestiom_Delete = "v1/commonquestiom/delete";
        public const string CommonQuestiom_ChangeStatus = "v1/commonquestiom/changestatus";
        #endregion

        #region ConstructorInformation
        public const string ConstructorInformation_GetAll = "v1/constructorinformation/getall";
        public const string ConstructorInformation_Get = "v1/constructorinformation/get";
        public const string ConstructorInformation_Add = "v1/constructorinformation/add";
        public const string ConstructorInformation_Update = "v1/constructorinformation/update";
        public const string ConstructorInformation_Delete = "v1/constructorinformation/delete";
        public const string ConstructorInformation_ChangeStatus = "v1/constructorinformation/changestatus";
        #endregion

        #region Logo
        public const string Logo_GetAll = "v1/logo/getall";
        public const string Logo_Get = "v1/logo/get";
        public const string Logo_Add = "v1/logo/add";
        public const string Logo_Update = "v1/logo/update";
        public const string Logo_Delete = "v1/logo/delete";
        public const string Logo_ChangeStatus = "v1/logo/changestatus";
        #endregion

        #region RealEstateServicc
        public const string RealEstateServicc_GetAll = "v1/realEstateServicc/getall";
        public const string RealEstateServicc_Get = "v1/realEstateServicc/get";
        public const string RealEstateServicc_Add = "v1/realEstateServicc/add";
        public const string RealEstateServicc_Update = "v1/realEstateServicc/update";
        public const string RealEstateServicc_Delete = "v1/realEstateServicc/delete";
        public const string RealEstateServicc_ChangeStatus = "v1/realEstateServicc/changestatus";
        #endregion

        #region Social
        public const string Social_GetAll = "v1/social/getall";
        public const string Social_Get = "v1/social/get";
        public const string Social_Add = "v1/social/add";
        public const string Social_Update = "v1/social/update";
        public const string Social_Delete = "v1/social/delete";
        public const string Social_ChangeStatus = "v1/social/changestatus";
        #endregion

        #region SpectacularLocation
        public const string SpectacularLocation_GetAll = "v1/spectacularLocation/getall";
        public const string SpectacularLocation_Get = "v1/spectacularLocation/get";
        public const string SpectacularLocation_Add = "v1/spectacularLocation/add";
        public const string SpectacularLocation_Update = "v1/spectacularLocation/update";
        public const string SpectacularLocation_Delete = "v1/spectacularLocation/delete";
        public const string SpectacularLocation_ChangeStatus = "v1/spectacularLocation/changestatus";
        #endregion

        #region SpectacularLocationImage
        public const string SpectacularLocationImage_GetAll = "v1/spectacularlocationimage/getall";
        public const string SpectacularLocationImage_GetAll_WithDetails = "v1/spectacularlocationimage/getall/withdetails";
        public const string SpectacularLocationImage_Get = "v1/spectacularlocationimage/get";
        public const string SpectacularLocationImage_Get_WithDetails = "v1/spectacularlocationimage/get/withdetails";
        public const string SpectacularLocationImage_Get_Filter = "v1/spectacularlocationimage/getbyfilter";
        public const string SpectacularLocationImage_Add = "v1/spectacularlocationimage/add";
        public const string SpectacularLocationImage_Update = "v1/spectacularlocationimage/update";
        public const string SpectacularLocationImage_Delete = "v1/spectacularlocationimage/delete";
        public const string SpectacularLocationImage_ChangeStatus = "v1/spectacularlocationimage/changestatus";
        #endregion

        #region TeamMember
        public const string TeamMember_GetAll = "v1/teammember/getall";
        public const string TeamMember_GetFilter = "v1/banner/filter-teammember";
        public const string TeamMember_Get = "v1/teammember/get";
        public const string TeamMember_Add = "v1/teammember/add";
        public const string TeamMember_Update = "v1/teammember/update";
        public const string TeamMember_Delete = "v1/teammember/delete";
        public const string TeamMember_ChangeStatus = "v1/teammember/changestatus";
        #endregion

        #region TeamMemberSocial
        public const string TeamMemberSocial_GetAll = "v1/teammembersocial/getall";
        public const string TeamMemberSocial_GetAll_WithDetails = "v1/teammembersocial/getall/withdetails";
        public const string TeamMemberSocial_Get = "v1/teammembersocial/get";
        public const string TeamMemberSocial_Get_WithDetails = "v1/teammembersocial/get/withdetails";
        public const string TeamMemberSocial_Get_Filter = "v1/teammembersocial/getbyfilter";
        public const string TeamMemberSocial_Add = "v1/teammembersocial/add";
        public const string TeamMemberSocial_Update = "v1/teammembersocial/update";
        public const string TeamMemberSocial_Delete = "v1/teammembersocial/delete";
        public const string TeamMemberSocial_ChangeStatus = "v1/teammembersocial/changestatus";
        #endregion

    }
}
