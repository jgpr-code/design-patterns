namespace FunctionalPatterns
namespace FunctionalPatterns.Behavioral

module Strategy =

    type SpeakingType =
        { speak: string -> unit }

    let screaming =
        { speak = fun (text: string) -> printfn "%s" (text.ToUpper()) }
    let slowTalking =
        { speak = fun (text: string) -> printfn "%s" (System.String.Join(' ', text.ToCharArray())) }

    let speakText speakingType text =
        speakingType.speak text

