using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen Ürün Adını Boş Geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(5)
                .WithMessage("Lütfen Ürün Adını 5 İle 150 Karakter Arasında Giriniz.");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen Stok Bilgisini Boş Geçmeyiniz.")
                .Must(s => s >= 0)
                .WithMessage("Stok Bilgisi Negatif Olamaz.");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen Fiyat Bilgisini Boş Geçmeyiniz.")
                .Must(s => s >= 0)
                .WithMessage("Fiyat Bilgisi Negatif Olamaz.");

        }
    }
}
