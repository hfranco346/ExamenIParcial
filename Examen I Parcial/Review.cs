using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.ComponentModel.DataAnnotations;

namespace Examen_I_Parcial
{
    class Review
    {
        public int productReviewId { get; set; }
        public int productId { get; set; }
        public string reviewerName { get; set; }
        public DateTime reviewDate { get; set; }
        public string emailAddress { get; set; }
        public int rating { get; set; }
        public string comments { get; set; }
        public DateTime modifiedDate { get; set; }

        public static bool InsertarReview(Review review)
        {
            SqlConnection conn = new SqlConnection(@"server = .\sqlexpress;
                integrated security = true; database = AdventureWorks2014");
            string sql;

            sql = "Insert into Production.ProductReview (ProductId, ReviewerName, ReviewDate, EmailAddress, Rating, Comments, ModifiedDate) Values (@productId, @name, @reviewDate, @email, @rating, @comments, @modifiedDate)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                if (!new EmailAddressAttribute().IsValid(review.emailAddress))
                    throw new CustomException("¡Dirección de correo no válida! Favor verifique.", "Información");

                using (cmd)
                {
                    cmd.Parameters.Add("@productId", SqlDbType.Int).Value = review.productId;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = review.reviewerName;
                    cmd.Parameters.Add("@reviewDate", SqlDbType.DateTime).Value = review.reviewDate;
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = review.emailAddress;
                    cmd.Parameters.Add("@rating", SqlDbType.Int).Value = review.rating;
                    cmd.Parameters.Add("@comments", SqlDbType.NVarChar, 3850).Value = review.comments;
                    cmd.Parameters.Add("@modifiedDate", SqlDbType.DateTime).Value = review.modifiedDate;

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (CustomException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
