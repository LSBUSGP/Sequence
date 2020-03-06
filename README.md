# Sequence

Detect a sequence of 3 presses distinguished by the duration of the press. The program outputs the result on the console.

This script has the following properties:

- [Press Durations](#Press-Durations)
- [Sequences](#Sequences)
- [Button](#Button)

## Press Durations

The property `Press Durations` represents the maximum length of each duration in increasing order:

1. short
2. medium
3. long

The duration is in seconds and any time up to the first duration is identified as short `1`; up to the next as medium `2`; and so on. If a duration is longer than the maximum long duration, it is marked as an error `X`. Note that in the Unity editor the indices are 0, 1, and 2 because Unity indexes it's arrays from 0.

## Sequences

The property `Sequences` represents the sequences to detect. Each sequence is a string of 3 numbers representing a valid sequence of 3 detected durations. For example, the sequence `123` represents a short press, followed by a medium press, followed by a long press.

## Button

The property `Button` is the button mapped in the `Input` settings used to trigger the detection. You can set this to any button input that you have mapped.

## How it works

The program counts up the `heldTime` while the button is held down. When the button is released, it compares the `heldTime` against the `pressDurations` and adds to the currently recorded sequence. Finally, if the sequence has 3 identifiers, it compares against its list of known sequences to see if it has a match.
