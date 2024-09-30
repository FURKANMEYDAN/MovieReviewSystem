using FluentValidation;
using MoviReviewSystem;
using MoviReviewSystem.Application.Commands;


namespace MoviReviewSystem.Application.Validators


{
    public class AddReviewCommandValidator : AbstractValidator<AddReviewCommand>
    {
        public AddReviewCommandValidator(){
            RuleFor(x=>x.Content).NotEmpty().WithMessage("İnceleme Boş olamaz");
            RuleFor(x=>x.Rating).InclusiveBetween(1,5).WithMessage("Puan 1-5 arasında olmalıdır.");
        }
    }
}