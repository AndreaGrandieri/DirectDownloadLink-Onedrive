---
# Front matter of "classic" page

# Theme to use. Resides in the "_layouts" folder.
layout: default

# Page title. If omitted, the page will not be included in the navbar.
title: DirectDownloadLink-Onedrive

#################################################################

# Specifies the order of the current page from the point of view of the navbar. Can have repetition in the numbers, for parent-child hierarchies.
nav_order: 1

# Let exclude the page from the navbar
nav_exclude: false

# Let exclude the page from the built-in search engine
search_exclude: false

#################################################################

# Set "true" if this page has childrens, "false" otherwise.
has_children: false

# If this page is some page's child, specify the parent's name, otherwise comment out the option. If this page is some page's grandchild, specify grandparent's name, otherwise comment out the option.
# # parent: NOME_PAGINA_GENITORE
# # grand_parent: NOME_PAGINA_NONNO__GENITORE_DEL_GENITORE

# If this page is a parent page, a Table Of Contents will be automatically generated containing all related child pages. Use the option below to disable this functionality. Should always be set to "false".
has_toc: false

#################################################################

# Specify the current language of this page
lang: en

# Specify all other available languages in which this page is available. If there's no other language in addition to "lang", comment out this option.
# # availableLanguages:
# #   - 

# Notice: codeblocks highlighting supported languages listed here: https://www.fabriziomusacchio.com/blog/2021-08-11-Syntax_Highlighting_in_Jekyll/
---

# DirectDownloadLink-Onedrive
{: .no_toc }
{: .d-inline-block }

<div id="projects-label-1"></div>
{: .d-inline-block }

<script type="module">
  selfsustainable_fill_labels_state("projects-label-1");
</script>

<div id="projects-label-2"></div>

<script type="module">
  selfsustainable_fill_labels_state("projects-label-2");
</script>

---

<!-- Table of contents -->
<details open markdown="block">
  <summary>
    Table of contents
  </summary>
  {: .text-delta }
1. TOC
{:toc}
</details>

---

{: .motto-title }
> <p class="blockquote-title-fixer-purple">tl;dr</p>
>
> Create __Direct Download Link__ for __Onedrive__ given a _classic_ sharable link.

---

## Autori

- Andrea Grandieri [https://github.com/AndreaGrandieri](https://github.com/AndreaGrandieri)

---

The following project makes you able to create __Direct Download Link__ for __Onedrive__
given a _classic_ sharable link.

Here's the difference:

- Onedrive Classic Sharing Link: it opens a web interface to visualize the file and download
  it using an embedded (gui) botton
- Direct Download Link Onedrive: it lets you immediately download the requested file, throught
  the Microsoft API. Perfect to share a _mirror like_ link, mostly used for automatic programs
  that aren't able to interact with a gui!

You can download the Visual Studio solution or run the following snippet in any C# environment:

> ONLY FOR PERSONAL ONEDRIVE USE. NO BUSINESS (SHAREPOINT) COMPATIBILITY.
> ONLY FOR SINGLE FILE. NO FOLDER COMPATIBILITY!!

```csharp
/*
 * @author: Andrea Grandieri g.andreus02@gmail.com https://github.com/AndreaGrandieri
 */

using System;

/*
 * ONLY FOR PERSONAL ONEDRIVE USE. NO BUSINESS (SHAREPOINT) COMPATIBILITY.
 * ONLY FOR SINGLE FILE. NO FOLDER COMPATIBILITY!!
 */

/*
 * Il seguente programma permette, partendo da un link di sharing OneDrive (NON DI UNA
 * CARTELLA!) di ottenere un link Direct-Download.
 * Differenza:
 * - Link di sharing OneDrive: apre una interfaccia web per visualizzare il file, scaricabile
 * attraverso l'uso di un bottone dell'interfaccia
 * - Link Direct-Download: scarica direttamente il file, utilizzando le API di Microsoft.
 * Perfetto per fornire link di download di tipo "mirror", utilizzati soprattutto da programmi
 * automatici che non sarebbero in grado di interagire con una interfaccia grafica!
 */

/*
 * - Onedrive Classic Sharing Link: it opens a web interface to visualize the file and download
 * it using an embedded (gui) botton
 * - Direct Download Link Onedrive: it lets you immediately download the requested file, throught
 * the Microsoft API. Perfect to share a _mirror like_ link, mostly used for automatic programs
 * that aren't able to interact with a gui!
 */

namespace DirectDownloadLink_Onedrive
{
    class Program
    {
        static void Main(string[] args)
        {
            // Place here your CLASSIC sharing link (e.g.: https://1drv.ms/u/s!AmstWNn8EkEu73A68W56jHwFltEn?e=qBCpvd)
            string sharingUrl = "";
            string base64Value = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(sharingUrl));
            string encodedUrl = "u!" + base64Value.TrimEnd('=').Replace('/', '_').Replace('+', '-');
            string resultUrl = string.Format("https://api.onedrive.com/v1.0/shares/{0}/root/content", encodedUrl);

            // Here you're printing the resulting link. THIS IS YOUR READY-TO-USE (PERMANENT) DIRECT DOWNLOAD LINK.
            // Just copy it and you are all set!
            Console.WriteLine(resultUrl);
            Console.ReadLine();
        }
    }
}

```

---

## Obtaining the "Classic Sharing Link"

1. Choose your file and click on `Share`. This panel will show:

  [![1.PNG](/DirectDownloadLink-Onedrive/assets/1.PNG)](/DirectDownloadLink-Onedrive/assets/1.PNG)

2. Now you have to change the privacy for the file: __it has to be set on READ-ONLY-SHARING__ (unckeck `Allow modify`):

  [![2.jpg](/DirectDownloadLink-Onedrive/assets/2.jpg)](/DirectDownloadLink-Onedrive/assets/2.jpg)

3. Now your panel should look like this:

  [![3.png](/DirectDownloadLink-Onedrive/assets/3.png)](/DirectDownloadLink-Onedrive/assets/3.png)

4. Finally get your _classic_ read only sharing link:

  [![4.png](/DirectDownloadLink-Onedrive/assets/4.png)](/DirectDownloadLink-Onedrive/assets/4.png)
