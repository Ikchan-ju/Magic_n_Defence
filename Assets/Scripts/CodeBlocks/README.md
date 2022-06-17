# CodeBlocks
These are the components of User Generate Game Spells.
To create the custom spell, user lays codeblocks on magic circle. And it works on a rule made by programming logic.
There are two kinds of interfaces which are ICodeBlock and IElementBlock.

structure of spell design system

    Spells : ClassBlock
    ├── Loop
    |   ├── For
    |   └── While
    └── ClassBlock
        ├── Condition
        |   ├── LogicalOpertation (Numeric)
        |   |   ├── ManaInputBlock
        |   |   ├── LogicalOperatorBlock
        |   |   └── NumBlock
        |   └── Attribution
        |       └── TBD
        └── Action
            ├── Generator
            ├── Amplifier
            ├── Duplicator
            └── TBD
