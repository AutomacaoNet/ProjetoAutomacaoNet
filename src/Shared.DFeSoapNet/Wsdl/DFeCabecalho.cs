﻿using CoreNet.Entidades;
using CoreNet.Flags;

namespace DFeSoapNet.Wsdl
{
    public class DFeCabecalho
    {
        public DFeCabecalho(Estado codigoUF, VersaoServico versaoServico, ITagCabecalho tagCabecalho, string namespaceHeader)
        {
            CodigoUF = codigoUF;
            VersaoServico = versaoServico;
            NamespaceHeader = namespaceHeader;
            TagCabecalho = tagCabecalho;
        }

        public string NamespaceHeader { get; }
        public Estado CodigoUF { get; }
        public VersaoServico VersaoServico { get; }
        public ITagCabecalho TagCabecalho { get; }

        public string GetXmlHeader()
        {
            return TagCabecalho.GetTagCabecalho(this);
        }

    }
}
