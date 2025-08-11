﻿---
prepare: |
  var client = this.UseService<IClientProvider>();
---

# Card

<Ingress Text="Organize content in visually grouped containers with headers, footers, and actions to create structured, professional layouts." />

The `Card` widget is a versatile container used to group related content and actions in Ivy applications. It can hold text, buttons, charts, and other widgets, making it a fundamental building block for creating structured layouts.

## Basic Usage

Here's a simple example of a card containing text and a button that shows a toast message when clicked.

```csharp demo-below ivy-bg
new Card(
    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam nec purus nec nunc",
    new Button("Sign Me Up", _ => client.Toast("You have signed up!"))
).Title("Card App").Description("This is a card app.").Width(Size.Units(100))
```

<WidgetDocs Type="Ivy.Card" ExtensionTypes="Ivy.CardExtensions" SourceUrl="https://github.com/Ivy-Interactive/Ivy-Framework/blob/main/Ivy/Widgets/Card.cs"/>