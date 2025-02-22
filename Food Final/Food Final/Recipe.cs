//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Food_Final
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recipe()
        {
            this.RecipeIngredients = new HashSet<RecipeIngredient>();
            this.RecipeIngredients1 = new HashSet<RecipeIngredient>();
            this.UserFavorites = new HashSet<UserFavorite>();
            this.UserFavorites1 = new HashSet<UserFavorite>();
            this.UserRatingsReviews = new HashSet<UserRatingsReview>();
            this.UserRatingsReviews1 = new HashSet<UserRatingsReview>();
        }
    
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public Nullable<int> PreparationTime { get; set; }
        public Nullable<decimal> AverageRating { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeIngredient> RecipeIngredients1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFavorite> UserFavorites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFavorite> UserFavorites1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRatingsReview> UserRatingsReviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRatingsReview> UserRatingsReviews1 { get; set; }
    }
}
