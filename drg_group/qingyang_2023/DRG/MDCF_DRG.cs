namespace drg_group.qingyang_2023
{
    public class MDCF_DRG 
    {
    
        public static bool FB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FD39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FE29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FF29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FK39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FL39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM39_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM49_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FN29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FP19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT49_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR41_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FV31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FW21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool FF33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FM23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FR43_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FT33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FU23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FV13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FV23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FV33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FW13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FW23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool FF35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FM25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FR45_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FT35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FU25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FV35_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW15_group(MedicalRecord record){
            return true;
        }
    
        public static bool FW25_group(MedicalRecord record){
            return true;
        }
    
        public static bool FZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
