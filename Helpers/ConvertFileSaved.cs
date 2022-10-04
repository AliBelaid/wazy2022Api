namespace wazyApi.Helpers
{
    public static  class ConvertFileSaved
    {
       static IWebHostEnvironment hoting;
           private static string UplaodFileDto(this IFormFile file )
        {
            string fileName = null;
            if (file != null)
            {
                string uploadDir = Path.Combine(hoting.WebRootPath, "Upload");
                fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var filrStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(filrStream);
                }

            }
            return fileName;
        }
    }
}