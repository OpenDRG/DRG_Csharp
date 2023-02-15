namespace drg_group.wuhan_2022
{
    public class MDCX_DRG 
    {
    
        public static bool XR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool XR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool XS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool XJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool XS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool XT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool XT31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool XS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool XT33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool XJ1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool XS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT35_group(MedicalRecord record){
            return true;
        }
    
    }
}
