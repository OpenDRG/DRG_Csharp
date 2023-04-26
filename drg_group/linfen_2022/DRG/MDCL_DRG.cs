namespace drg_group.linfen_2022
{
    public class MDCL_DRG 
    {
    
        public static bool LA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool LC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LX19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LA21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LD11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LF11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LL11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LA23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LE13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LF13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LL13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LA25_group(MedicalRecord record){
            return true;
        }
    
        public static bool LD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LE15_group(MedicalRecord record){
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
    
        public static bool LU15_group(MedicalRecord record){
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
