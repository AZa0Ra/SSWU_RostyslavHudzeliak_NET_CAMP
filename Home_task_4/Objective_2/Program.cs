using Objective_2;

Email email = new Email("simple@example.com very.common@example.com disposable.style.email.with+symbol@example.com other.email-with-hyphen@example.com" +
                " fully-qualified-domain@example.com user.name+tag+sorting@example.com x@example.com example-indeed@strange-example.com" +
                " example@s.example \"john..doe\"@example.org mailhost!username@example.org user%example.com@example.org" +
                " Abc.example.com A@b@c@example.com 1234567890123456789012345678901234567890123456789012345678901234+x@example.com" +
                " i_like_underscore@but_its_not_allow_in_this_part.example.com a\"(c)d,e:f;g<h>i[j\\k]l@example.com");

email.SortEmails();
Console.WriteLine(email.ToString());