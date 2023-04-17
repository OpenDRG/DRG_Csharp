namespace drg_group.yancheng_2023
{
    public class MDCL_DRG 
    {
    
        public static bool LA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LA29_group(MedicalRecord record){
            return true;
        }
    
        public static bool LB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LX19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LB21_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LF11_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LL11_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LS11_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LV11_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LW11_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LB25_group(MedicalRecord record){
            return true;
        }
    
        public static bool LF15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LL15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LV15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LW15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
