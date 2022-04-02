using System;
using FluentValidation;

namespace Notes.Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommandValidator : AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteCommandValidator()
        {
            RuleFor(CreateNoteCommand =>
                CreateNoteCommand.Title).NotEmpty().MaximumLength(250);
            RuleFor(CreateNoteCommand =>
                CreateNoteCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
