﻿using System.Collections.Generic;

namespace ContractApi.Data.Converter
{
    public interface IParse <O,D>
    {

        D Parse(O origin);
        List<D> ParseList(List<O> origin);

    }
}
