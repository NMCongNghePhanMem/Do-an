﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;
using System.Data;

namespace BusinessLogicTier
{
    public class PhanQuyenBUS
    {
        PhanQuyenDAO m_PhanQuyen;

        public PhanQuyenBUS()
        {
            m_PhanQuyen = new PhanQuyenDAO();
        }

        public DataTable KiemTraMatKhau(PhanQuyenDTO _phanQuyen)
        {
            return m_PhanQuyen.KiemTraMatKhau(_phanQuyen);
        }
    }
}
