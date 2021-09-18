using System;
using System.IO.MemoryMappedFiles;

namespace SharedMemory
{
    public static class SharedMemoryClient
    {
        static MemoryMappedFile accPhysics = MemoryMappedFile.OpenExisting("Local\\acpmf_physics");
        static MemoryMappedFile accGraphics = MemoryMappedFile.OpenExisting("Local\\acpmf_static");
        static MemoryMappedFile accStatic = MemoryMappedFile.OpenExisting("Local\\acpmf_static");

        static MemoryMappedFileAccess access = MemoryMappedFileAccess.Read;
        private static string fileString { get; set; }

        public static MemoryMappedFile initializePhysics()
        {
            try
            {
                if (accPhysics != null)
                {
                    accPhysics.CreateViewAccessor(0, 0, access);
                }
                return accPhysics;
            }
            catch(Exception ex)
            {
                
            }
            return null;
        }

        public static MemoryMappedFile initializeGraphics()
        {
            try
            {
                if (accGraphics != null)
                {
                    accGraphics.CreateViewAccessor(0, 0, access);
                }
                return accPhysics;
            }
            catch (Exception ex)
            {

            }
            return null;
        }
        public static MemoryMappedFile initializeStatic()
        {
            try
            {
                if (accStatic != null)
                {
                    accStatic.CreateViewAccessor(0, 0, access);
                }
                return accPhysics;
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
